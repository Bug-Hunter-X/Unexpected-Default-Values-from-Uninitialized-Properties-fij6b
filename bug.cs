public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property before it's assigned a value
        int value = MyProperty; // This will result in a default value of 0
    }
}