using System;
using System.Collections.Generic;
using System.ComponentModel;
using GraphQL.Client;
using GraphQL.Common.Request;
using GraphQL.Common.Response;
using Xamarin.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GraphQlApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
          
            var client = new GraphQLClient("https://swapi.apis.guru/");
          
            GraphQLRequest graphQlRequest = new GraphQLRequest()
            {


           Query =  "query{ allFilms{ films { id,title,director } }}"
   



    };

          



            GraphQLResponse graphQLResponse = await client.PostAsync(graphQlRequest);
            



            List<Film> films = graphQLResponse.Data.allFilms.films.ToObject<List<Film>>();

            
            film_list.ItemsSource = films;


        
            base.OnAppearing();

        }
    }
}
