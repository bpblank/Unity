

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



#### 消息

| [OnCollisionEnter](https://docs.unity3d.com/cn/current/ScriptReference/Collider.OnCollisionEnter.html) | 当该碰撞体/刚体已开始接触另一个刚体/碰撞体时，调用 OnCollisionEnter。 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| [OnCollisionExit](https://docs.unity3d.com/cn/current/ScriptReference/Collider.OnCollisionExit.html) | 当该碰撞体/刚体已停止接触另一个刚体/碰撞体时，调用 OnCollisionExit。 |
| [OnCollisionStay](https://docs.unity3d.com/cn/current/ScriptReference/Collider.OnCollisionStay.html) | 对应正在接触刚体/碰撞体的每一个碰撞体/刚体，每帧调用一次 OnCollisionStay。 |
| [OnTriggerEnter](https://docs.unity3d.com/cn/current/ScriptReference/Collider.OnTriggerEnter.html) | GameObject 与另一个 GameObject 碰撞时，Unity 会调用 OnTriggerEnter。 |
| [OnTriggerExit](https://docs.unity3d.com/cn/current/ScriptReference/Collider.OnTriggerExit.html) | 当 Collider other 已停止接触该触发器时调用 OnTriggerExit。   |
| [OnTriggerStay](https://docs.unity3d.com/cn/current/ScriptReference/Collider.OnTriggerStay.html) | 对于正在接触该触发器的每个其他 Collider，“几乎”所有帧都调用 OnTriggerStay。此函数位于物理计时器上，因此它不必运行每个帧。 |







### Rigidbody 2D 组件

1. Gravity Scale 控制物体的重力
2. Constraints 控制物体的偏移方向 x y z轴。

+ 物体的刚体组件
  + 可以让物体对受力做出反应，让物体拥有动态受力的功能，Collider只是给物体加上了碰撞，让物体拥有了实体
  + 只要刚体的速度低于sleepAngularVelocity和sleepVelocity，该刚体就会开始休眠。其空闲一些帧后，就会被设置成休眠状态。处于休眠状态中的物体，不会再对其进行碰撞检测和模拟。这会节约大量的CPU开销。

- 参数：
  - mass： 物体的质量
  - Drag: 平移阻力，用来表示物体因物体受阻力而速度衰减的状态
  - Angular Drag： 旋转阻力，模拟物体应旋转而受到的各方面影响的现象
  - gravity Scale： 表示物体是否受重力影响
  - Freeze Rotation： 表示物体的旋转是否受到物理的控制
  - Interpolate ： 物体运动的插值模式，选择这个模式，会在物体运动帧之间进行插值，使运动更加自然。

| ***属性：\***                | ***功能：\***                                                |
| :--------------------------- | :----------------------------------------------------------- |
| **Mass**                     | 对象的质量（默认为千克）。                                   |
| **Drag**                     | 根据力移动对象时影响对象的空气阻力大小。0 表示没有空气阻力，无穷大使对象立即停止移动。 |
| **Angular Drag**             | 根据扭矩旋转对象时影响对象的空气阻力大小。0 表示没有空气阻力。请注意，如果直接将对象的 Angular Drag 属性设置为无穷大，无法使对象停止旋转。 |
| **Use Gravity**              | 如果启用此属性，则对象将受重力影响。                         |
| **Is Kinematic**             | 如果启用此选项，则对象将不会被物理引擎驱动，只能通过__变换 (Transform)__ 对其进行操作。对于移动平台，或者如果要动画化附加了 **HingeJoint** 的刚体，此属性将非常有用。 |
| **Interpolate**              | 仅当在刚体运动中看到急动时才尝试使用提供的选项之一。         |
| - **None**                   | 不应用插值。                                                 |
| - **Interpolate**            | 根据前一帧的变换来平滑变换。                                 |
| - **Extrapolate**            | 根据下一帧的估计变换来平滑变换。                             |
| **Collision Detection**      | 用于防止快速移动的对象穿过其他对象而不检测碰撞。             |
| - **Discrete**               | 对场景中的所有其他碰撞体使用离散碰撞检测。其他碰撞体在测试碰撞时会使用离散碰撞检测。用于正常碰撞（这是默认值）。 |
| - **Continuous**             | 对动态碰撞体（具有刚体）使用离散碰撞检测，并对静态碰撞体（没有刚体）使用基于扫掠的连续碰撞检测。设置为__连续动态 (Continuous Dynamic)__ 的刚体将在测试与该刚体的碰撞时使用连续碰撞检测。其他刚体将使用离散碰撞检测。用于__连续动态 (Continuous Dynamic)__ 检测需要碰撞的对象。（此属性对物理性能有很大影响，如果没有快速对象的碰撞问题，请将其保留为 **Discrete** 设置） |
| - **Continuous Dynamic**     | 对设置为__连续 (Continuous)__ 和__连续动态 (Continuous Dynamic)__ 碰撞的游戏对象使用基于扫掠的连续碰撞检测。还将对静态碰撞体（没有刚体）使用连续碰撞检测。对于所有其他碰撞体，使用离散碰撞检测。用于快速移动的对象。 |
| - **Continuous Speculative** | 对刚体和碰撞体使用推测性连续碰撞检测。这也是可以设置运动物体的唯一 CCD 模式。该方法通常比基于扫掠的连续碰撞检测的成本更低。 |
| **Constraints**              | 对刚体运动的限制：                                           |
| - **Freeze Position**        | 有选择地停止刚体沿世界 X、Y 和 Z 轴的移动。                  |
| - **Freeze Rotation**        | 有选择地停止刚体围绕局部 X、Y 和 Z 轴旋转。                  |





### Object 类

#### Instantiate

+ 克隆 `original` 对象并返回克隆对象。返回**Object** 实例化的克隆对象。

+ 此函数会通过与编辑器中的复制命令类似的方式创建对象的副本。如果要克隆 [GameObject](https://docs.unity3d.com/cn/current/ScriptReference/GameObject.html)，则可以指定其位置和旋转（否则，这些默认为原始 GameObject 的位置和旋转）。如果要克隆 [Component](https://docs.unity3d.com/cn/current/ScriptReference/Component.html)，则也会克隆它附加到的 GameObject（同样可指定可选的位置和旋转）。

  克隆 [GameObject](https://docs.unity3d.com/cn/current/ScriptReference/GameObject.html) 或 [Component](https://docs.unity3d.com/cn/current/ScriptReference/Component.html) 时，也将克隆所有子对象和组件，它们的属性设置与原始对象相同。



#### Quaternion

+ 四元数

Quaternion.Euler（x,y,z） : 将欧拉角转换成四元数。





### Box Collider 2d 组件

| ***属性\***           | ***功能\***                                                  |
| :-------------------- | :----------------------------------------------------------- |
| **Material**          | 一种物理材质，可用于确定碰撞的属性（例如摩擦和弹性）。       |
| **Is Trigger**        | 如果希望 2D 盒型碰撞体作为触发器运行，请选中此框。           |
| **Used by Effector**  | 如果希望 2D 盒型碰撞体由附加的 2D 效应器组件使用，请选中此框。 |
| **Used by Composite** | 如果希望此碰撞体由附加的 [2D 复合碰撞体 (Composite Collider 2D)](https://docs.unity3d.com/cn/current/Manual/class-CompositeCollider2D.html) 使用，请勾选此复选框。  启用 **Used by Composite** 时，其他属性会从 2D 盒型碰撞体组件中消失，因为这些属性现在由附加的 2D 复合碰撞体控制。从 2D 盒型碰撞体消失的属性为 **Material**、**Is Trigger**、**Used By Effector** 和 **Edge Radius**。 |
| **Auto Tiling**       | 如果所选精灵的[精灵渲染器 (Sprite Renderer)](https://docs.unity3d.com/cn/current/Manual/class-SpriteRenderer.html) 组件将 **Draw Mode** 设置为 **Tiled__，请勾选此复选框。这样可以自动更新 [2D 碰撞体](https://docs.unity3d.com/cn/current/Manual/Collider2D.html)的形状，意味着精灵的尺寸变化时，会自动重新调整形状。如果没有启用** Auto Tiling__，2D 碰撞体几何形状不会自动重复。 |
| **Offset**            | 设置 2D 碰撞体几何形状的局部偏移。                           |
| **Size**              | 按局部空间单位设置盒体的大小。                               |
| **Edge Radius**       | 控制边缘周围的半径，使顶点为圆形。这会产生一个具有圆凸角的更大 [2D 碰撞体](https://docs.unity3d.com/cn/current/Manual/Collider2D.html)。此设置的默认值是 __0__（无半径）。 |







