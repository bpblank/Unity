

### MonoBehavior类

+ MonoBehaviour 是一个基类，所有 Unity 脚本都派生自该类。

#### Start方法和 Update方法 ：代码运行周期

+ **Start Method**：仅在第一次脚本启动Update()方法被调用之前被调用。

+ **Update Method**：该函数每帧调用一次，上一帧调用Update函数到现在消耗的时间，需要使用`Time.deltaTime`

  > 帧： 影像动画中最小的单位，一帧就是一幅静止的画面，fps：帧数，一秒内传输图片的帧数。









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