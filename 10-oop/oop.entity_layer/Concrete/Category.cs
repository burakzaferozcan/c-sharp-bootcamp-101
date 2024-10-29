namespace oop.entity_layer.Concrete;

public class Category
{
    // Access Modifilers
    // private, public, internal, protected
    
    // field : direkt olarak bir sınıfın içine tanımlanırsa, int x;
    int x;

    // property : get set ile tanımlanırsa, public int y {get; set;};
    public int y { get; set; }
     
    // variable : fonksiyon içerisinde tanımlanırsa, void test(){int z;}
    void test()
    {
        int z;
    }
     
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public bool CategoryStatus { get; set; }
}