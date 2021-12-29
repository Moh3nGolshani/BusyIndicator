# BusyIndicator
BusyIndicator for WPF with multiple indicator types.  

<p align="center">
  <img src="https://github.com/Peoky/BusyIndicator/blob/master/Images/Demo.gif" alt="Demo" style="width: 50%;"></img>
</p>

<p align="center">
  <img src="https://github.com/Peoky/BusyIndicator/blob/master/Images/Indicators.gif" alt="Indicator Types" width="95%"></img> 
</p>

## Prerequisites:
<ul><li>.Net Framework 4.6 or higher</li></ul>  
<ul><li>.Net Core 3.1 or higher</li></ul>  

## How to use:
1. Install the package via [NuGet](https://www.nuget.org/packages/BusyIndicator/)    
<pre>Install-Package BusyIndicator</pre>  

2. Add resources to App.xaml  
<pre><code>&lt;ResourceDictionary&gt;
            &lt;ResourceDictionary.MergedDictionaries&gt;
                &lt;ResourceDictionary&gt;
                    &lt;ResourceDictionary.MergedDictionaries&gt;
                        &lt;ResourceDictionary Source="pack://application:,,,/BusyIndicator;component/BusyMask/BusyMask.xaml"/&gt;
                        &lt;ResourceDictionary Source="pack://application:,,,/BusyIndicator;component/Indicator/Indicator.xaml"/&gt;
                    &lt;/ResourceDictionary.MergedDictionaries&gt;
                &lt;/ResourceDictionary&gt;
            &lt;/ResourceDictionary.MergedDictionaries&gt;
&lt;/ResourceDictionary&gt;
</code></pre>  

3. Add a reference to the library in your view  
<pre>xmlns:busyIndicator="https://github.com/Peoky/BusyIndicator"</pre>  

4. Create a BusyMask on top of main view  
<pre><code>&lt;busyindicator:BusyMask x:Name="BusyIndicator" IsBusy="False" IndicatorType="Dashes" BusyContent="Please wait..." &gt;  
         
         
          <... main view goes here ... >
         
         
&lt;/busyIndicator:BusyMask&gt;</code></pre>  

5. Set `IsBusy` property value to `true` or `false` or bind it
<pre>BusyIndicator.IsBusy = true; or BusyIndicator.IsBusy = false; </pre>  

### How to change indicator colors:
Indicator colors can be changed now, All you have to do is overriding the colors on your Window, UserControl or even BusyMask resources like below:
<pre>
    &lt;Window.Resources>
        &lt;SolidColorBrush x:Key="IndicatorForeground" Color="Orange" />
        &lt;SolidColorBrush x:Key="IndicatorBackground" Color="WhiteSmoke" />
    &lt;/Window.Resources>
</pre>  

You can also use gradients

<pre>
&lt;LinearGradientBrush x:Key="IndicatorForeground" StartPoint="0.5,0" EndPoint="0.5,1">
    &lt;GradientStop Offset="1" Color="#eaafc8" />
    &lt;GradientStop Offset="0" Color="#654ea3" />
&lt;/LinearGradientBrush>
</pre> 

#### Hint: 
>Not all indicators have background, so that change background might not affect all indicators.

##
If you like this, give it a * please.

<a href="https://www.buymeacoffee.com/coffeemakes" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-green.png" alt="Buy Me A Coffee" style="height: 60px !important;width: 217px !important;" ></a>


