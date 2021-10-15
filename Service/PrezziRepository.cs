using System.Linq;
using PrezziWebApi.Models;

namespace PrezziWebApi.Service
{
    public class PrezziRepository : IPrezziRepository
    {
        Prezzi[] prezzi = new Prezzi[]
        {
            new Prezzi{Isbn = "B08KH1B786", Prezzo = 6.90},
            new Prezzi{Isbn = "B08R5MD353", Prezzo = 9.90},
            new Prezzi{Isbn = "B08XWV5SMR", Prezzo = 9.90}
        };
        public double SelPrezzo(string Isbn)
        {
            Prezzi prezzo = this.prezzi.Where(c => c.Isbn.Equals(Isbn)).FirstOrDefault();
            
            return (prezzo != null) ? prezzo.Prezzo : -1;
        }
    }
}