using UnityEngine;
using TMPro;


public class PlayerMovement : MonoBehaviour
{

	[SerializeField] private TextMeshProUGUI koinebi;
	public static bool GameISPaused = false;
	public GameObject PauseMeniuUi;
	public cubermovoment controller;
	public Animator animator;
	public Rigidbody2D rb;
	public bool movemarjvniv;
	public bool movemarcxniv;
	public bool moveaxtoma;
	public bool movechakuzva;
	public float horizontalMove;
	public float speed = 5f;
	bool jump = false;
	bool crouch = false;
	public Vector3 respawnpoint;
	public GameObject infomenu;
	public GameObject infomenu2;
	public GameObject infomenu3;
	public int loadscene;
	public int koini;
	
	
	
	void Start()
    {
		rb = GetComponent<Rigidbody2D>();
		movemarcxniv = false;
		movemarjvniv = false;
		//respawnpoint = transform.position;
		LoadPlayer();
		
		
	}
	
    public void Downmarcxena()
    {
		movemarcxniv = true;
		
		
    }
	public void Upmarcxena()
	{
		movemarcxniv = false;
	}
	public void Downmarjvena()
	{
		movemarjvniv = true;
	}
	public void Upmarjvena()
	{
		movemarjvniv = false;
	}
	// Update is called once per frame
	void Update()
	{
		MovePlayer();
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

	}

	private void MovePlayer()
    {
		if (movemarcxniv)
        {
			horizontalMove = -speed;
        }
		else if (movemarjvniv)
        {
			horizontalMove = speed;
        }
        else
        {
			horizontalMove = 0f;
        }
    }
	public void axtoma()
    {
		//GetComponent<Rigidbody2D>().AddForce(Vector2.up * Time.deltaTime * axtomis_dzala);
		jump = true;
		animator.SetBool("IsJumping", true);
	}
	public void archakuzva()
    {
		crouch = false;
		//animator.SetBool("IsCrouch", false);

	}
	public void chakuzva()
	{
		//GetComponent<Rigidbody2D>().AddForce(Vector2.up * Time.deltaTime * axtomis_dzala);
		crouch  = true;
		//animator.SetBool("IsCrouchi", true);
	}
	public void OnCrouching(bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching );
	}
	public void OnLanding()
    {
		animator.SetBool("IsJumping", false);
    }
	void FixedUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;

	

	}
	public void Resume()
	{
		PauseMeniuUi.SetActive(false);
		Time.timeScale = 1f;
		GameISPaused = false;
		LoadPlayer();
	}
	public void saveplayer()
    {
		SaveSystem.SavePalyer(this);
		Debug.Log("shenaxulia");
    }
	public void LoadPlayer()
    {
		Vector3 position;
		PlayerData data = SaveSystem.loadplayer();
		position.x = data.position[0];
		position.y = data.position[1];
		position.z = data.position[2];
		transform.position = position;
		koini = data.koini;
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "chck")
		{
			//respawnpoint = transform.position;
			saveplayer();
			Debug.Log("shenaxuul");
		}
		else if (collision.tag == "trap")
		{
			//transform.position = respawnpoint;
			
			LoadPlayer();
			PauseMeniuUi.SetActive(true);
			Time.timeScale = 0f;
			GameISPaused = true;
			
		}
		else if (collision.tag == "info")
		{
			infomenu.SetActive(true);

		}
		else if (collision.tag == "info2")
		{
			infomenu2.SetActive(true);

		}
		else if (collision.tag == "troled")
		{
			infomenu3.SetActive(true);

		}
		else if (collision.gameObject.CompareTag("formula"))
		{
			Destroy(collision.gameObject);
			koini++;
			koinebi.text = koini + "formula";
			//if (koini == 4)
			//{
			//WinnerScreen.SetActive(true);
			//Destroy(gameObject);
			//}
		}else if (collision.tag == "levelis_dasasruli")
        {
			if (koini >= 0)
            {
				//Time.timeScale = 0f;
				transform.position = respawnpoint;
                
				
			}
            else
            {
				Debug.Log(" mojvi koinebi");
				
            }
			
			
		}




	}
		public void infos_gatishva()
    {
		infomenu.SetActive(false);
		infomenu2.SetActive(false);
		infomenu3.SetActive(false);
	}
	

}
