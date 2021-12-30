### 物体通过键盘上下左右移动

1. 通过`Input`类下的`getAxis()`方法获取键盘输入上下左右时的值
2. 根据`Transform`类下的`Translate`方法将物体转移到相应的位置。

#### 物体移动方向的时候一起按时，会斜方向移动

1. 添加移动的优先级，增添if判断，当完成一个方向的移动时，不执行下面的操作。

#### 如何控制单个物体的图片方向问题

1. 根据按下的按钮来控制`SpriteRendererd`的 渲染对象

### 游戏体碰撞设计

1. 两个碰撞体之间需要有碰撞器collider。
2. 在运动的一方需要挂在刚体Rigidbody。
   + 静止的久了会不触发刚体的属性，所以需要将刚体赋给Rigidbody

#### 游戏碰撞过程中，抖动

1. 游戏逻辑放入FixedUpdate函数中。

### 层级的渲染

1. 通过精灵渲染组件中的Order in Layer 设计层级。

### Unity游戏的游戏周期

#### 初始阶段

Awake():  执行时间，创建游戏对象时，立刻执行一次。

Start():  创建对象，脚本启动，执行一次。//  数据和游戏逻辑的初始化。

#### 物理阶段

FixedUpdate():  固定更新，当脚本启用时， 固定时间被调用。// 适合游戏对象的物理操作；

OnCollisonXXX碰撞： 当满足碰撞条件时调用。

OnTriggerXXX触发，当满足触发条件时调用。

#### 游戏逻辑：

Update（）： 每帧执行一次，

LateUpdate（）：延迟更新，在前者被调用后执行。

#### 输入事件：

OnMouseEnter鼠标移入当前Colider时调用，

OnMouseOver鼠标经过当前碰撞器时调用，

相同的还有OnMouseExit鼠标离开，

OnMouseDown鼠标按下，

OnMouseUp鼠标抬起；

#### 场景渲染：

OnBecameVisible：在Mesh Renderer在任何相机上可见时调用。

OnBecameInvisible：在Mesh Renderer在任何相机上都不可见时调用。



#### 结束阶段：

OnDisable： 对象变为不可用或附属游戏对象非激活状态时，此函数被调用。

OnDestroy：当脚本销毁或附属的游戏对象被销毁时被调用。

OnApplicationQuit：应用程序退出时被调用。



### 碰撞器

一、碰撞器

碰撞的条件：

1）两者都要具有碰撞组件也就是Collider;

2）运动的物体具有刚体组件Rigidbody

碰撞的三阶段:
1)当进入碰撞时执行 void OnCollisionEnter(Collison collOther)

2)当碰撞体与刚体触发时每帧执行void OnCollisionStay(Collision collOther)
    
3)当停止碰撞时执行void OnCollisionExit(Collision collOther)



### 触发器

二、触发器

触发器：带有碰撞组件，且Is Trigger属性被勾选的物体，现象就是无碰撞效果。

触发条件：
1）两者具有碰撞组件Collider；

2）其中之一带有刚体组件，两者都有也可；
3）其中之一勾选Is Trigger，两者都有也可；

触发三阶段：
1）当Collider碰撞体进入触发器时执行 void OnTriggerEnter(Collider collOther)

2)  当碰撞体与触发器接触时每帧执行 void OnTriggerStay(Collider collOther)
    
3）当停止触发时执行void OnTriggerExit(Collider collOther)

### 空气墙的制作

+ 将碰撞器添加到墙体并将预制体渲染关闭。

> tips： 在给物体添加预制体属性的时候，需要先添加变量，然后再将预制体进行关联。

### Camera中看不见物体场景

**Culling Mask、Layer、z坐标设置错误**

------

1、解决Camera下Culling Mask设置错误

检查一下Culling Mask是否为“Everything”，有时我们为了创作需要，会更改Culling Mask，如果你的Culling Mask选项为“Mixed”，那么很有可能是Culling Mask设置错误 设置成everything

2、解决Layer设置错误

设置Layer时千千万万要注意，层次关系一定不要搞错，检查一下有没有被背景或其他精灵挡住，再检查Layer视图里有没有开启显示该Layer

没有必要的话最好设置成everything

3、解决z坐标设置错误

这是2D游戏开发中最最最最最容易忽略的一个错误，因为大多数游戏角色的Transform都是一直在变化的，因此很多人都会忽略掉Transform里的坐标，更别说一个在2D游戏开发中没有多大用处的z坐标了。