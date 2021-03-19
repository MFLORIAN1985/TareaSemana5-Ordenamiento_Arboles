

/**
 *
 * @author Ruldin
 */
public class Estudiante : Comparador {

  
    public string nombre;
  

    public bool igualQue(object q)
    {
        return true;
    }

    public bool mayorIgualQue(object q)
    {
        //Compara dos objetos String especificados y devuelve un entero que indica su posición relativa en el criterio de ordenación

        //Compara cadenas para responder una de dos preguntas: "¿Son estas dos cadenas iguales?" o 
        //"¿En qué orden deben colocarse estas cadenas al clasificarlas?"


        Estudiante ordenar = (Estudiante)q;
        return nombre.CompareTo(ordenar.nombre) >= 0;//ordenar.nombre es el siguiente nombre a comparar

    }

    public bool mayorQue(object q)
    {
        Estudiante ordenar = (Estudiante)q;
        return nombre.CompareTo(ordenar.nombre) > 0;
    }

    public bool menorIgualQue(object q)
    {
        Estudiante ordenar = (Estudiante)q;
        return nombre.CompareTo(ordenar.nombre) <= 0;
    }

    public bool menorQue(object q) {
       
        Estudiante ordenar = (Estudiante)q;
        return nombre.CompareTo(ordenar.nombre) < 0;
    }

}
