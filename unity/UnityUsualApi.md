

### MonoBehavior类

+ MonoBehaviour 是一个基类，所有 Unity 脚本都派生自该类。

#### Start方法和 Update方法 ：代码运行周期

+ **Start Method**：仅在第一次脚本启动Update()方法被调用之前被调用。

+ **Update Method**：该函数每帧调用一次，上一帧调用Update函数到现在消耗的时间，需要使用`Time.deltaTime`

  > 帧： 影像动画中最小的单位，一帧就是一幅静止的画面，fps：帧数，一秒内传输图片的帧数。

#### FixedUpdate方法

+ 当物体的移动为速度*Time.deltaTime的时候，物体是按照时间来进行移动的。
+ 而Update函数在调用的时候是每一帧调用一次，而根据电脑的运行情况，每一帧的时间都不一样。
+ FixedUpdate 函数是真实时间，在固定的时间间隔内执行，不受游戏帧率影响。
+ 修改FixedUpdate 在**Edit** - **Project Setting** - **time** 找到 **Fixed timestep**修改。在设置物体刚体时，最好将代码逻辑放入FixedUpdate方法中。







### Input类

+ 用于访问输入系统的接口。



#### GetAxis() 和 GetAxisRaw()

```c#
public static float GetAxis (string axisName);
// 返回由axisName表示的虚拟轴的值。
```

+ **axisName**： `Edit > Settings > Input` 窗口中查看其他输入轴。

+ GetAxisRaw() ： 相较于GetAxis() 为应用平滑过滤。

> 水平范围和垂直范围从 0 变为 +1 或 -1，以 0.05f 的步幅增加/减少。GetAxisRaw 立即从 0 变为 1 或 -1，因此没有步幅。





### Transform类

#### Translate

```C#
public void Translate (Vector3 translation);
public void Translate (Vector3 translation, Space relativeTo= Space.Self);
//根据 translation 的方向和距离移动变换。
//如果 relativeTo 被省略或设置为 Space.Self，则会相对于变换的本地轴来应用该移动。（在场景视/图中选择对象时显示的 X、Y 和 Z 轴。） 如果 relativeTo 为 Space.World，则相对于世界坐标系应用该移动。

public void Translate (float x, float y, float z);
public void Translate (float x, float y, float z, Space relativeTo= Space.Self);
//将变换沿 X 轴移动 /x/、沿 Y 轴移动 /y/、沿 Z 轴移动 /z/。
//如果 relativeTo 被省略或设置为 Space.Self，则会相对于变换的本地轴来应用该移动。（在场景视图中选择对象时显示的 X、Y 和 Z 轴。） 如果 relativeTo 为 Space.World，则相对于世界坐标系应用该移动。

public void Translate (Vector3 translation, Transform relativeTo);
//根据 translation 的方向和距离移动变换。
//相对于 relativeTo 的本地坐标系应用移动。 如果 relativeTo 为 null，则相对于世界坐标系应用移动。
```

#### transfrom.forward

+ 自动对物体旋转值算出前进方向向量的变量。
+ Vector3.forward 表示（0，0，1）



### Vector3

+ struct in UnityEngine
+ 用于表示 3D 向量和点

1. 静态变量
   1. down （0，-1，0）
   2. left（-1，0，0）
   3. one（1，1，1）
   4. right（1，0，0）
   5. up（0，1，0）
2. 变量
   1. x y z



### .Meta文件

+ 定义在它同目录下，同名的非meta文件的唯一ID：**GUID**。而对于unity的序列化文件来说，引用的对象用的就是这个GUID。
+ 存储资源文件的ImportSetting数据。在上文中资源文件是有ImportSetting数据的，这个数据正数存储在meta文件中。ImportSetting中专门有存储Assetbundle相关的数据。这些数据帮助编辑器去搜集所有需要打包的文件并分门别类。所以每一次修改配置都会修改meta文件。

#### GUID

+ guid是meta中最最最重要的数据。这个guid代表了这个文件，无论这个文件是什么类型（甚至是文件夹）。换句话说，通过GUID就可以找到工程中的这个文件，无论它在项目的什么位置。

20211222

------

### Sprite Renderer

+ 2D图形渲染精灵

#### 变量

1. sprite ： 渲染的对象
2. maskInteraction： 指定精灵如何与遮罩交互
3. tileMode： 精灵渲染器当前的平铺模式
4. Material：返回该对象的所有实例化材质。
5. sortingOrder：设置排序图层中渲染器的顺序



### Component

#### GetComponent(type name)

1. 如果游戏对象有附加type类型的组件，则返回，如果没有则为空。





### Collider

所有碰撞体的基类







### Rigidbody 2D 组件

1. Gravity Scale 控制物体的重力
2. Constraints 控制物体的偏移方向 x y z轴。





### Object 类

#### Instantiate

+ 克隆 `original` 对象并返回克隆对象。返回**Object** 实例化的克隆对象。

+ 此函数会通过与编辑器中的复制命令类似的方式创建对象的副本。如果要克隆 [GameObject](https://docs.unity3d.com/cn/current/ScriptReference/GameObject.html)，则可以指定其位置和旋转（否则，这些默认为原始 GameObject 的位置和旋转）。如果要克隆 [Component](https://docs.unity3d.com/cn/current/ScriptReference/Component.html)，则也会克隆它附加到的 GameObject（同样可指定可选的位置和旋转）。

  克隆 [GameObject](https://docs.unity3d.com/cn/current/ScriptReference/GameObject.html) 或 [Component](https://docs.unity3d.com/cn/current/ScriptReference/Component.html) 时，也将克隆所有子对象和组件，它们的属性设置与原始对象相同。



#### Quaternion

+ 四元数

Quaternion.Euler（x,y,z） : 将欧拉角转换成四元数。







