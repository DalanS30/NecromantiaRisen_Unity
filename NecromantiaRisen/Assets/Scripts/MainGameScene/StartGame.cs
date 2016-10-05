using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Text;
using System.IO;
using System;

public class StartGame : MonoBehaviour
{
    private Text gameTextBox = GameObject.Find("GameTextBox").GetComponent<Text>();
    private string currentFile = "0";

    // Use this for initialization
    void Start()
    {
        string text = "failed";
        LoadFile(currentFile, out text);
        gameTextBox.text = text;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private bool LoadFile(string fileName, out string text)
    {
        try
        {
            string line, path = string.Format("StoryTextFiles/{0}.txt", fileName);
            StreamReader reader = new StreamReader(fileName, Encoding.Default);
            using (reader)
            {
                StringBuilder builder = new StringBuilder();
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        builder.Append(line);
                    }
                } while (line != null);

                reader.Close();
                text = builder.ToString();
                return true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("{0}\n", e.Message);
            text = string.Empty;
            return false;
        }
    }
}
