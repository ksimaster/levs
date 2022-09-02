using UnityEngine;

public class TriggerAction : MonoBehaviour {
	public GameObject triggerPanel;
    public GameObject monstr;

    void  OnTriggerEnter ( Collider col){
        if (col.tag == "Player") 
        {
            triggerPanel.SetActive(true);
            gameObject.SetActive(false);
            monstr.SetActive(false);
        } 

	}
}