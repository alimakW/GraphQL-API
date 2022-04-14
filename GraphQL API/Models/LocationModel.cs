namespace GraphQL_API.Models
{
    public class LocationModel
    {
        private string name { get; set; }
        private string url { get; set; }

        public LocationModel(string name, string url)
        {
            this.name = name;
            this.url = url;
        }


    }
}
