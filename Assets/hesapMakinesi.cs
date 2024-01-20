using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class hesapMakinesi : MonoBehaviour
{
    public TMP_InputField sayi1;
    public TMP_InputField sayi2;
    public TextMeshProUGUI sonuc;
    decimal sayi_1;
    decimal sayi_2;
    public void toplaFonk()
    {
       sayi_1 = decimal.Parse(sayi1.text);
       sayi_2 = decimal.Parse(sayi2.text);
       sonuc.text = "Sonuç: " + (sayi_1 + sayi_2).ToString();
    }
    public void cikarFonk()
    {
        sayi_1 = decimal.Parse(sayi1.text);
        sayi_2 = decimal.Parse(sayi2.text);
        sonuc.text = "Sonuç: " + (sayi_1 - sayi_2).ToString();
    }
    public void carpFonk()
    {
        sayi_1 = decimal.Parse(sayi1.text);
        sayi_2 = decimal.Parse(sayi2.text);
        sonuc.text = "Sonuç: " + (sayi_1 * sayi_2).ToString();
    }
    public void bolFonk()
    {
        sayi_1 = decimal.Parse(sayi1.text);
        sayi_2 = decimal.Parse(sayi2.text);
        sonuc.text = "Sonuç: " + (sayi_1 / sayi_2).ToString();
    }
}
