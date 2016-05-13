using System;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;

namespace TDC2016
{
    public class AzureServices
    {
        public MobileServiceClient MobileService { get; set; }

        IMobileServiceSyncTable<EventFeedback> avTable;
        IMobileServiceSyncTable<TrackFeedback> avTrackTable;


        bool isInitialized;

        public async Task Initialize()
        {

            if (isInitialized)
                return;

            MobileService = new MobileServiceClient("http://seudominio.azurewebsites.net/");

            const string path = "avstdc16.db";
            //setup our local sqlite store and intialize our table
            var store = new MobileServiceSQLiteStore(path);

            store.DefineTable<EventFeedback>();
            store.DefineTable<TrackFeedback>();

            await MobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());

            //Get our sync table that will call out to azure
            avTable = MobileService.GetSyncTable<EventFeedback>();
            avTrackTable = MobileService.GetSyncTable<TrackFeedback>();

            isInitialized = true;
        }

        public async Task AddAv(TrackFeedback tc)
        {
            try
            {


                await avTrackTable.InsertAsync(tc);

                await avTrackTable.PullAsync("allTrackFeedback", avTrackTable.CreateQuery());

                await MobileService.SyncContext.PushAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        public async Task AddAv(string pkEvento, string pkENetworking, string pkOrg, string pkAlimentacao, string pkCusto)
        {

            var av = new EventFeedback()
            {
                avAlimentacao = pkAlimentacao,
                avCusto = pkCusto,
                avEvento = pkEvento,
                avNetworking = pkENetworking,
                avOrganizacao = pkOrg,
                IDCracha = App.Cracha
            };
            try
            {


                await avTable.InsertAsync(av);

                await avTable.PullAsync ("allEventFeedback", avTable.CreateQuery ());

                

                await MobileService.SyncContext.PushAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

    }
}

