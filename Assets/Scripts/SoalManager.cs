using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoalManager : MonoBehaviour
{
    [System.Serializable]
    public class Soal
    {
        [TextArea]
        [Header("Soal")]
        public string soal;

        [Header("Pilihan Jawaban")]
        public string pilA; 
        public string pilB, pilC, pilD;

        [Header("Kunci Jawaban")]
        public bool A;
        public bool B, C, D;
    }

    Text textSoal, textA, textB, textC, textD;
    public List<Soal> KumpulanSoal;

    int nilaiAcak;

    // Start is called before the first frame update
    void Start()
    {
        textSoal = GameObject.Find("TextSoal").GetComponent<Text>();
        textA = GameObject.Find("A").GetComponent<Text>();
        textB = GameObject.Find("B").GetComponent<Text>();
        textC = GameObject.Find("C").GetComponent<Text>();
        textD = GameObject.Find("D").GetComponent<Text>();

        nilaiAcak = Random.RandomRange(0, KumpulanSoal.Count);
    }

    // Update is called once per frame
    void Update()
    {
        textSoal.text = KumpulanSoal[nilaiAcak].soal;
        textA.text = KumpulanSoal[nilaiAcak].pilA;
        textB.text = KumpulanSoal[nilaiAcak].pilB;
        textC.text = KumpulanSoal[nilaiAcak].pilC;
        textD.text = KumpulanSoal[nilaiAcak].pilD;

        //Menghapus soal
        //KumpulanSoal.RemoveAt(nilaiAcak);
    }
}
