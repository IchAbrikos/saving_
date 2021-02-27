using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Saving : MonoBehaviour
{
   public static int level = 1;
    public Button[] buttons;
    public static string path = @"file.txt";

    // public static void Save();
 
    void ButActiv()
    {
        for(int i =0; i<buttons.Length; i++)
        {
            if(i < level)
        {
            buttons[i].interactable=true;
        }
        else
        {
         buttons[i].interactable=false;   
        }
        }
    }

    public static void Read()
    {
        if(!File.Exists(path))
        {
            File.Create(path);
        //    Saving.Save();          
        }
    else
    {
        using(StreamReader sr = File.OpenText(path))
        {
            level = int.Parse(sr.ReadLine());
            sr.Close();
        }
    }

    }

    public static void Save()
    {
        using(StreamWriter sw = File.CreateText(path))
        {
            sw.WriteLine(level.ToString());
            sw.Close();
        }
    }

    void Start()
    {
        Read();
        ButActiv();
    }
}
