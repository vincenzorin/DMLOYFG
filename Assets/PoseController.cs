using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseController : MonoBehaviour
{
    public GameObject PoseGameObject;
    public HumanDescription humanDescription;

    // Start is called before the first frame update
    void Start()
    {
        Avatar avatar = AvatarBuilder.BuildHumanAvatar(PoseGameObject, new HumanDescription());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
