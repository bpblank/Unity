### 索引器

+ 作为一种特殊的属性，允许一个对象可以像数组一样被索引。

语法格式

```C#
[修饰符][类型] this[参数列表]{
    get{get访问器};
    set{set访问器};
}
```

+ 索引的名称必须是this，且后面一定要跟[]，至少要有一个参数



### 泛型

+ 利用同一个方法来处理传入不同种类参数的办法。
+ 有泛型方法和泛型类和泛型接口。



### 类

类中只能包含常量，变量，以及各种函数；

变量可以先声明，然后再在函数内部进行复制。

常量需要再声明的时候初始化。

base能在子类重写父类的方法后重新调用父类的方法

`base.method`

访问父类成员只能再函数进行。



### 单例模式

```C#
// 只会返回一个实例。
private static 类名 instance;
public static 类名 Instance{
    get{
        if (instance == null){
            instance = new 类名；
        }
        return instance;
    }
}


//如果继承了MonoBehaviour
//那么可以写成
public static 类名 字段名；
private void Awake(){
    instance = this;
}

// 单例模板
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    public static T Instance { get; private set; }

    protected void Awake()
    {
        if (Instance == null)
        {
            Instance = (T) this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
```

#### get() set() 方法

```c#
public string name;
public string Name{
    get(return name);
    set(name = value);
}
```

#### 泛型中where约束

定义：在定义**泛型**的时候，我们可以使用 **where** 限制**参数**的范围。

使用：在使用**泛型**的时候，你必须尊守 **where** 限制**参数**的范围，否则编译不会通过。

+ 用于类

+ ```
  指定GenericList中的类型参数必须是Employee或者是派生于Employee
  public class Employee{}
  
  public class GenericList<T> where T : Employee
  ```

+ 用于方法

```
public bool MyMethod<T>(T t) where T : IMyInterface { }
```