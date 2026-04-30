using System.Collections.Generic;
using UnityEngine;

public class MostraStelline : MonoBehaviour
{
    public int totStelleDaMostrare;

    public List<GameObject> stelline;

    public void AggiornaNumero(int totaleDaMostrare)
    {
        totStelleDaMostrare = totaleDaMostrare;
        int i = 0;
        foreach (GameObject go in stelline) {
            if (i < totStelleDaMostrare)
            {
                go.SetActive(true);
            }
            else
            {
                go.SetActive(false);
            }
            i++;
        }
    }
}
