using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable] // tells Unity this class can save/modify inside Unity
public class Questions {

    public string question; // the question the user needs to answer	
    public bool istrue;
    public AudioClip QuestionAudio;
}
