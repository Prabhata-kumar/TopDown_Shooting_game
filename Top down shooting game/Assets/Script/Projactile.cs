using UnityEngine;

public class Projactile : MonoBehaviour
{
   // private Camera MainCamera;
    private Vector2 target;
    public float speed;


    // Start is called before the first frame update
    private void Start()
    {
        //Cursor.                                                                                               v
    }

    private void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = Vector2.MoveTowards(transform.position,target,speed * Time.deltaTime);
        if(Vector2.Distance(transform.position,target) < 0.02f)
        {
            Destroy(gameObject);
        }   
    }

}
