using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyCollision : MonoBehaviour
{
    GameObject GangStar1;
    Animator animatorGangStar1;
    // Start is called before the first frame update
    void Start()
    {
        GangStar1 = GameObject.Find("GangStar1");
        if(GangStar1 == null)
        {
            Debug.LogError("Ennemie non trouvé");
        }
        animatorGangStar1 = GangStar1.GetComponent<Animator>();
        if(animatorGangStar1 == null)
        {
            Debug.LogError("Animation non trouvé");
        }
            
    }

    // Fonction qui permet la detection de notre ennemi
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "GangStar1")
        {
            Debug.Log("Ennemie detecté");
            animatorGangStar1.SetInteger("GangStarEtat", 1);
        }
    }
}
