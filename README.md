# BusyIndicator
BusyIndicator for Windows Presentation Foundation (WPF)

<p align="center">
  <img src="https://github.com/moh3ngolshani/BusyIndicator/blob/master/Images/Demo.gif" alt="Demo" style="width: 50%;"></img>
</p>

<p align="center">
  <img src="https://github.com/moh3ngolshani/BusyIndicator/blob/master/Images/Indicators.gif" alt="Indicator Types" width="95%"></img>
</p>

## Prerequisites:
<ul><li>.Net Framework 4.6+</li></ul>
<ul><li>.Net Core6+</li></ul>

## How to use:

1. Install the package via [NuGet](https://www.nuget.org/packages/BusyIndicators):
<pre>Install-Package BusyIndicators</pre>

> **Note**
> NuGet address is changed!  
<br />

2. Add resource call to App.xaml:
<pre><code>&lt;Application.Resources&gt;
     &lt;ResourceDictionary Source="pack://application:,,,/BusyIndicator;component/Theme/Default.xaml"/&gt;
&lt;/Application.Resources&gt;
</code></pre>  

3. Add a reference to the library:
<pre>xmlns:busyIndicator="https://github.com/moh3ngolshani/BusyIndicator"</pre>

4. Create a BusyMask on top of main view:
<pre><code>&lt;busyIndicator:BusyMask x:Name="BusyIndicator" 
                        IsBusy="False" 
                        IndicatorType="Dashes" 
                        BusyContent="Please wait..." 
                        BusyContentMargin="0,20,0,0" 
                        IsBusyAtStartup="False" &gt;
         
         
          <... MAIN VIEW GOES HERE... >
         
         
&lt;/busyIndicator:BusyMask&gt;</code></pre>

5. Bind or Set `IsBusy` property.

### How to change indicator sizes:
Indicator sizes can be changed now:

* Add a reference to the mscorlib assembly:
<pre>xmlns:sys="clr-namespace:System;assembly=mscorlib"</pre>

* Override the `IndicatorScaleX` & `IndicatorScaleY`:

<pre>
&lt;Window.Resources>
    &lt;sys:Double x:Key="IndicatorScaleX" >2&lt;/sys:Double>
    &lt;sys:Double x:Key="IndicatorScaleY" >2&lt;/sys:Double>
&lt;/Window.Resources>
</pre>

### How to change indicator colors:
Override the `IndicatorForeground` & `IndicatorBackground`:

<pre>
&lt;Window.Resources>
    &lt;SolidColorBrush x:Key="IndicatorForeground" Color="Orange" />
    &lt;SolidColorBrush x:Key="IndicatorBackground" Color="WhiteSmoke" />
&lt;/Window.Resources>
</pre>  

You can also use gradients:

<pre>
&lt;LinearGradientBrush x:Key="IndicatorForeground" StartPoint="0.5,0" EndPoint="0.5,1">
    &lt;GradientStop Offset="1" Color="#eaafc8" />
    &lt;GradientStop Offset="0" Color="#654ea3" />
&lt;/LinearGradientBrush>
</pre> 

#### Hint: 
>Not all indicators have background, so changing the `IndicatorBackground` might not affect all indicators.

##
If you like this, give it a * please.

<a href="https://www.buymeacoffee.com/coffeemakes" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-green.png" alt="Buy Me A Coffee" style="height: 60px !important;width: 217px !important;" ></a>

