using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    [SerializeField] private QuestSO questSO;
    [SerializeField] private PlayerQuests playerQuests;
    [SerializeField] private QuestGiverSO giverSO;
    [SerializeField] private GameObject dialog;

    private void Start()
    {
        playerQuests = PlayerConstantsHolder._playerConstantsHolder.playerQuests;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dialog?.SetActive(true);
            if (Input.GetKeyDown(KeyBindings.KeyCodes[KeyBindings.KeyCode_Interaction]))
            {
                var quests = playerQuests.CheckQuests(giverSO);
                foreach (var quest in quests)
                {
                    CompleteQuest(quest);
                }
                if (questSO != null)
                {
                    GiveQuest();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dialog.SetActive(false);
        }
    }

    public void GiveQuest()
    {
        playerQuests.AddQuest(questSO);
        questSO = null;
    }

    public void CompleteQuest(QuestSO questSO)
    {
        playerQuests.ComplateQuest(questSO);
    }
}
