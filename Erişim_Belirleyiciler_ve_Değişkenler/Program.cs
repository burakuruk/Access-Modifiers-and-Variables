using Erişim_Belirleyiciler_ve_Değişkenler.Classes;

public class Program
{
    static void Main()
    {
        User kullanici = new User();

        kullanici.SetAdSoyad("Ahmetburak Uruk");
        kullanici.SetYas(21);
        kullanici.Email = "Burakurukb@gmail.com";

        kullanici.BilgileriGoster();
    }
}