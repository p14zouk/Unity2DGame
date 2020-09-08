using UnityEngine;
using UnityEngine.UI;
public class EndTrigger : MonoBehaviour
{   
    public Text textFinalTime;
    public Text textScore;
    public GameManager gameManager;
    public CherryPicker cherry;
    public Timer timer;
    void OnTriggerEnter2D (){
        gameManager.CompleteLevel();
        textScore.text = cherry.Cherry.ToString();
        textFinalTime.text = timer.timeStart.ToString();
    }
 
}
