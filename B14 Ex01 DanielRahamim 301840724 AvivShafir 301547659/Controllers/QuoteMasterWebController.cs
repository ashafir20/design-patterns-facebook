using B14_Ex01_Daniel_301840724_Aviv_301547659.Model.Rageface;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers
{
    class QuoteMasterWebController
    {
        private string k_UrlGetPath = "https://webknox-jokes.p.mashape.com/jokes/random";
        public void GetQuote()
        {
            HttpResponse<QuoteMasterJson> response = Unirest.get(k_UrlGetPath)
                      .header("X-Mashape-Authorization", "KUG53mMZefgA4hIRXTrRhBO5k8Z2zrXc")
                      .asJson<QuoteMasterJson>();
        }
    }
}
