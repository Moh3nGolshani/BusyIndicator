# BusyIndicator
BusyIndicator for WPF with multiple indicator types.  

<p align="center">
  <img src="https://github.com/Peoky/BusyIndicator/blob/master/Images/Demo.gif" alt="Demo" style="width: 50%;"></img>
</p>

<p align="center">
  <img src="https://github.com/Peoky/BusyIndicator/blob/master/Images/Indicators.gif" alt="Indicator Types" width="95%"></img> 
</p>

## Prerequisites:
<ul><li>.Net Framework 4.5 or higher</li></ul>  
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
<pre>xmlns:busyindicator="clr-namespace:BusyIndicator;assembly=BusyIndicator"</pre>  

4. Create a BusyMask on top of main view  
<pre><code>&lt;busyindicator:BusyMask x:Name="BusyIndicator" IsBusy="False" IndicatorType="DashLoader" BusyContent="Please wait..." &gt;  
         
         
          <... main view goes here .. >
         
         
&lt;/busyindicator:BusyMask&gt;</code></pre>  

5. Set `IsBusy` property value to `true` or `false` to enable or disable the mask (or bind it)[check demo for a working example]
<pre>BusyIndicator.IsBusy = true; or BusyIndicator.IsBusy = false; </pre>  

##
If you like this, give it a * please.

<a href="https://www.buymeacoffee.com/coffeemakes" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-green.png" alt="Buy Me A Coffee" style="height: 60px !important;width: 217px !important;" ></a>


