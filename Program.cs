using System;
class Review{

    public int calificacion {get; set;}
    public string comentario {get;set;}

    public Review (int calificacion, string comentario){
        this.calificacion = calificacion;
        this.comentario = comentario;
    }

    public override string ToString(){
            return $"({this.calificacion} - {this.comentario})";

        }

}


class Producto{

    public string nombre;
    public int precio;
    public List<Review> reviews = new List<Review>();

    public Producto(string nombre, int precio, List<Review> lis){
        this.nombre = nombre;
        this.precio = precio;
        this.reviews = lis;
    }

    public void AgregarReview(Review review){
        reviews.Add(review);
    }

    public List<Review> ObtenerReviews(){
        return reviews;
    }


}


public class Program{

    public static void Main(){
        List<Review> list = new List<Review>{};
        Producto producto = new Producto("Fanta", 80, list);
       
        //Probar metodo obtenerReviews que muestra las reseñas que tiene el producto
        Review review1 = new (2, "no es saludable");
        producto.AgregarReview(review1);
        Console.WriteLine($"Reviews de {producto.nombre}: [{String.Join(',',producto.ObtenerReviews())}]");
        

        //Probar de nuevo el método AgregarReview que agrega una nueva reseña del producto
        Review review2 = new (4, "deliciosa");
        producto.AgregarReview(review2);
        Console.WriteLine($"Reviews de {producto.nombre}: [{String.Join(',',producto.ObtenerReviews())}]");
        


        
    }
}
