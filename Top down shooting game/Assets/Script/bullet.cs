using UnityEngine;

public class bullet : MonoBehaviour
{
    private Camera mainCamera;
    public Vector2 traget;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       // mainCamera = GetComponent<Camera>();
       // traget  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
 }

    // Update is called once per frame
    void Update()
    {
       //traget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // transform.position = Vector2.MoveTowards(transform.position, traget, speed * Time.deltaTime);
    }
}
