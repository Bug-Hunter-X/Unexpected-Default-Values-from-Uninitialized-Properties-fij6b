public class MyClass {
    public int? MyProperty { get; set; }

    public void MyMethod() {
        // Now MyProperty is nullable, explicitly check for null
        int? value = MyProperty; 
        if (value.HasValue) {
            // Use the value if it's assigned
            Console.WriteLine(value.Value);
        } else {
            // Handle the case where it's null
            Console.WriteLine("MyProperty is null");
        }
    }
}