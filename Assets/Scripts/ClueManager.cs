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
        if (clueOpen && Input.GetKeyDown(KeyCode.Escape))
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

            case 2:

                bodyText.text =
                "The ritual is complete...\n" +
                "Yet I can feel His presence drawing\n" +
                "closer with every breath.\n" +
                "The cursed manuscript still bears His name\n" +
                "As long as those pages remain untouched,\n" +
                "the seal will never truly break.\n" +
                "Burn the forbidden book...\n" +
                "Before it begins to whisper yours.";

                break;

            case 3:

                bodyText.text =
                "Forgive me...\n" +
                "I was never meant to lead another\n" +
                "soul into this place.\n" +
                "The Rust Key has broken the final seal.\n" +
                "They have heard it.\n" +
                "Their whispers will soon become footsteps.\n" +
                "Do not let them reach you.\n" +
                "Find the ancient door...\n" +
                "And never look back.";

                break;

            case 4:

                bodyText.text =
                "The cursed pages have turned to ash...\n" +
                "At last, the prison loosens its grip.\n" +
                "Beneath the ashes lies the final relic...\n" +
                "A Rusted Key, hidden from those\n" +
                "who feared the truth.\n" +
                "Take it.\n" +
                "The door will not remain\n" +
                "sealed for long.";

                break;
        }
    }

    public void CloseClue()
    {
        cluePanel.SetActive(false);
 
        clueOpen = false;
    }
}