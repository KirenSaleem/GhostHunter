using UnityEngine;
using TMPro;

public class ClueManager : MonoBehaviour
{
    public GameObject cluePanel;

    public TMP_Text bodyText;

    private bool clueOpen = false;

    void Start()
    {
        cluePanel.SetActive(false);
        ShowClue(0);
    }

    void Update()
    {
        if (clueOpen && Input.GetKeyDown(KeyCode.S))
        {

            CloseClue();
        }
    }

    public void ShowClue(int clueNumber)
    {
        cluePanel.SetActive(true);

        clueOpen = true;

        switch (clueNumber)
        {
            case 0:


                 bodyText.text =
                "They sealed Him beneath the chamber,\n" +
                "believing stone could silence His whispers.\n" +
                "They were wrong.\n" +
                "Every night I hear Him clawing beneath\n" +
                "the forgotten bed...\n" +
                "Search where we buried our greatest sin.\n" +
                "The first light still waits below.";

                break;

            case 1:

                bodyText.text =
                "The sacred flame now rests in your hands.\n" +
                "Yet its light is weak...\n" +
                "Three forgotten candles still stand within\n" +
                "these cursed halls.\n" +
                "Awaken each flame before the darkness\n" +
                "swallows them forever.\n" +
                "Do not linger...\n" +
                "Something has already sensed your presence.";

                break;
        }
    }

    public void CloseClue()
    {
        cluePanel.SetActive(false);
 
        clueOpen = false;
    }
}