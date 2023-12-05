using UnityEngine;

public class SLIME : MonoBehaviour
{
    public GameObject player;
    public GameObject vrag;
    public float speed;
    public new Rigidbody2D rigidbody;
    public float forwardSpeed;
    public RuntimeAnimatorController animidle;
    public RuntimeAnimatorController animrun;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 player1 = player.transform.position;
        Vector2 vrag1 = vrag.transform.position;

        if (Vector2.Distance(player1, vrag1) < 10)
        {

            vrag.transform.position = Vector2.MoveTowards(vrag1, player1, speed * Time.deltaTime);
            Animator animator = transform.GetComponent<Animator>();
            animator.runtimeAnimatorController = animrun as RuntimeAnimatorController;

            if (player.transform.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(4.980589f, 4.514507f, 1f);


            }
            else if (player.transform.position.x < transform.position.x)
            {
                transform.localScale = new Vector3(-4.980589f, 4.514507f, 1f);
            }

        }
        else
        {
            Animator animator = transform.GetComponent<Animator>();
            animator.runtimeAnimatorController = animidle as RuntimeAnimatorController;

        }

    }




}