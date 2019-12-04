using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : Interactable
{
 
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Shows the dialog with a key press when
    // player is near interactable object
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if(dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }
    // dialog box will become inactive as player becomes out of range
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            contextOff.Raise();
            playerInRange = false;
            dialogBox.SetActive(false);
        }
    }
}
