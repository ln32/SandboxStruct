using UnityEngine;
using System;


// 평범한 observing
public class ManagingData<T>
{
    private T _value;

    public T Data
    {
        get
        {
            return this._value;
        }
        set
        {
            this._value = value;
            this.onChange?.Invoke(value);
        }
    }

    public Action<T> onChange = new((value) => {;});
}