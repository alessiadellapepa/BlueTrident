using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    //Data Definition

    public Text testo;
    List<float> listX = new List<float>();
    List<float> listY = new List<float>();
    List<float> listZ = new List<float>();
    List<float> listXangle = new List<float>();
    List<float> listYangle = new List<float>();
    List<float> listZangle = new List<float>();
    int size;
    int i = 0;
    float dSx,dSy,dSz;
    Vector3 velocity;
    Quaternion rot = new Quaternion();
    string path = "Assets/Registrazioni/E/1/";

    // Start is called before the first frame update
    void Start()
    {
         using (var reader = new StreamReader(path + "Accelerometro.csv"))
        {
            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                listX.Add(float.Parse(values[0]));
                listY.Add(float.Parse(values[1]));
                listZ.Add(float.Parse(values[2]));

            }
            size = listX.Count;
            
            //gameObject.transform.Translate(*1*Time.deltaTime);
        }

         using (var reader = new StreamReader(path + "GlobalAngle.csv"))
        {

            while (!reader.EndOfStream)
            {
                var lineA = reader.ReadLine();
                var valuesA = lineA.Split(',');

                listXangle.Add(float.Parse(valuesA[0]));
                listYangle.Add(float.Parse(valuesA[1]));
                listZangle.Add(float.Parse(valuesA[2]));

            }
            
        }
        //transform.position += transform.forward * Time.deltaTime * 10;
    }

    private void FixedUpdate()
    {
        if (i < size)
        {
            rot.eulerAngles = new Vector3(listXangle[i], listYangle[i], listZangle[i]);

            dSx = (listX[i] * Time.deltaTime * Time.deltaTime)/10;
            dSy = (listY[i] * Time.deltaTime * Time.deltaTime)/10;
            dSz = (listZ[i] * Time.deltaTime * Time.deltaTime)/10;


            transform.rotation = rot;
            transform.position += new Vector3(dSx, dSy, dSz);
            
            i++;
            testo.text = "H: " + gameObject.transform.position.y;
        } else
        {
            testo.text = "FINE";
            velocity = new Vector3(0, 0, 0);
            GetComponent<Rigidbody>().velocity = velocity;
        }

    }
}
