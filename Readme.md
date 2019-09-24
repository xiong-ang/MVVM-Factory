# MVVM Factory
> MVVM实现了界面和数据的解耦，让界面设计和业务逻辑编写分离。在工程应用中，我们有如下需求：       
> 为了灵活使用WPF，我们往往创建大量的Views和ViewModels，遵循DRY原则，往往用到一个公共的接口来绑定View和ViewModel。      
> 为了支持WPF应用的扩展，有时我们需要提供插件接口，让用户提供定制化的Xaml UI，这就需要动态读取Xaml，创建界面控件，并绑定ViewModel。      
> 本文提供了以上需求的核心代码。    

## MVVM Core Concept
```C#
View.DataContext = ViewModel(Model);
```

## MVVM Factory
1. Create From UserControl
```C#
public static FrameworkElement CreateElement(FrameworkElement element, NotificationObject vm)
{
    if(null != element)
        element.DataContext = vm;

    return element;
}
```
2. Create From Xaml File
```C#
public static FrameworkElement CreateElementFromXmal(string xamlFile, NotificationObject vm)
{
    FrameworkElement element;
    using (FileStream fs = new FileStream(xamlFile, FileMode.Open))
    {
        element = (FrameworkElement)XamlReader.Load(fs);
    }

    return CreateElement(element, vm);
}
```

## Tips
* 通过加装Xaml文件的形式创建UserControl时，Xaml中不能包含class属性

## Reference
[0] http://www.iqiyi.com/w_19rrtat0a1.html    
[1] https://www.cnblogs.com/pbuilder/archive/2015/04/10/4414562.html
