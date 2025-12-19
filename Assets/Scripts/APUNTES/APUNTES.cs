using UnityEngine;

public class APUNTES : MonoBehaviour
{
    /*
     *
     * 
     */
    // cntrol+k+c (coment block)
    
    
    //Control + r + m (Extraer metodo <3)
    
    
    //Control+R+R sirve para cambiar el nombre de una variable de manera rapida (tambien sirve para los nombres de los scripts)
    //Alt izquierdo para para edición multilinea
    //A mas esplicita una variable mejor
    //alt + Enter Para ver las recomendaciones de Rider
    private int numeroA = 5; //Private: Solo accesible desde este script
    private string cadena = "hola mundo"; //Protectec: Solo accesible desde jerarquía de clases
    public bool envenenado = false; //Public: Desde cualquier punto del programa.

    [SerializeField] 
    private int NumeroB; //Mi niño bonito, precioso, hermoso, para cambiar valores en el inspector

    [Header("Main Stats")] //Separación con texto de variables
    [SerializeField] private int vida;
    [SerializeField] private int velocidad;

    private int numeroRandom;
    private float decimalRandom;
    [Header("TODO ES UN VALOR")]
    private Vector3 posiconInicial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numeroRandom = Random.Range(1, 100); //Numero aleatorio entre 1 y 99 (uno menos que el que pones)
        decimalRandom = Random.Range(1f, 100f);//Numero aleatorio con decimales entre 1 y 100 (la f es necesaria)
        Debug.Log(this.gameObject.transform.position.x);// Conseguir posición en X
        
        Debug.Log(this.gameObject.name); //this.gameObject hace referencia al game object a si mismo
        transform.position = new Vector2(3, 4);// NO SE RECOMIENDA USAR VECTOR 2 POR SUMAR INFO
        transform.eulerAngles = new Vector3(3, 4, 90);
        
        posiconInicial = new Vector3(3, 4,0);
        
    }
    

    // Update is called once per frame
    void Update()
    {
        EjemploInputs(); //Los imputs siempre en el Update
    }

    void EjemploInputs()
    {
        //Fases de toma de inputs por teclado
        
        if(Input.GetKeyDown(KeyCode.A)) //1º frame de presionar la tecla
        {
            Debug.Log("Hola mundo");
        }
        
        if(Input.GetKey(KeyCode.S)) //Todos los frames en los que se mantenga la tecla
        {
            Debug.Log("Hola mundo");
        }

        if (Input.GetKeyUp(KeyCode.D)) //1º frame en el que se deja de presionar una tecla
        {
            Debug.Log("Hola mundo");
        }
        
        
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-3f,0,0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(0,3f,0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position += new Vector3(0,-3f,0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(3f,0,0) * Time.deltaTime;
        }
        
        //gameObject.transform.position += new Vector3(0,1,0) * Time.deltaTime; //Time.deltaTime lo hace por segundo
    }
    
    
    
    
    //1. ForceMode.Force: Fuerza acumulable de empuje.
        
    //rb.AddForce(Vector3.forward * fuerza, ForceMode.Force);
}
