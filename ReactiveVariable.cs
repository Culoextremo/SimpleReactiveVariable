using System;

public class ReactiveVariable<T>
{
    public event Action<T> onValueChanged;
    private T value;

    public T Value
    {
        get
        {
            return this.value;
        }
        set
        {
            if (!Equals(this.value, value))
            {
                this.value = value;
                onValueChanged?.Invoke(value);
            }
        }
    }
}
