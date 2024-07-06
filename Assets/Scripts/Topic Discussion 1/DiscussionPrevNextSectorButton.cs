using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiscussionPrevNextSectorButton : MonoBehaviour
{
    public DiscussionNavigator discussionNavigator;
    public string action;

    public void OnClick()
    {
        discussionNavigator.changeSector(action);
    }
}
