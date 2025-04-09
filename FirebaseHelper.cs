using Firebase.Database;
using Firebase.Database.Query;

namespace AdrenalistApp
{
    internal class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://adrenalistapp-default-rtdb.asia-southeast1.firebasedatabase.app/");
        public async Task AddRecord(string rt, string cm, string pl)
        {
            await firebase
                .Child("AdrenalistApp")
                .PostAsync(new AdrenalistApp() { Rating = rt, Comment = cm, Place = pl });
        }
        public async Task AddRecord2(string rt2, string cm2, string pl2)
        {
            await firebase
                .Child("AdrenalistApp2")
                .PostAsync(new AdrenalistApp2() { Rating2 = rt2, Comment2 = cm2, Place2 = pl2 });
        }
        public async Task AddRecord3(string rt3, string cm3, string pl3)
        {
            await firebase
                .Child("AdrenalistApp3")
                .PostAsync(new AdrenalistApp3() { Rating3 = rt3, Comment3 = cm3, Place3 = pl3 });
        }
        public async Task<List<AdrenalistApp>> GetAllAdrenalistApp()
        {
            return (await firebase
            .Child("AdrenalistApp")
            .OnceAsync<AdrenalistApp>()).Select(item => new AdrenalistApp
            {
                Rating = item.Object.Rating,
                Comment = item.Object.Comment,
                Place = item.Object.Place
            }).ToList();
        }

        public async Task<List<AdrenalistApp2>> GetAllAdrenalistApp2()
        {
            return (await firebase
            .Child("AdrenalistApp2")
            .OnceAsync<AdrenalistApp2>()).Select(item => new AdrenalistApp2
            {
                Rating2 = item.Object.Rating2,
                Comment2 = item.Object.Comment2,
                Place2 = item.Object.Place2

            }).ToList();
        }

        public async Task<List<AdrenalistApp3>> GetAllAdrenalistApp3()
        {
            return (await firebase
            .Child("AdrenalistApp3")
            .OnceAsync<AdrenalistApp3>()).Select(item => new AdrenalistApp3
            {
                Rating3 = item.Object.Rating3,
                Comment3 = item.Object.Comment3,
                Place3 = item.Object.Place3

            }).ToList();
        }

        public async Task DeleteAdrenalistRecord(string key)
        {
            await firebase
               .Child("AdrenalistApp")
               .DeleteAsync();
        }

    }
}
   
