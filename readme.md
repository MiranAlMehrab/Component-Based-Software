I have created three different components which implement three different "Provides interface"s. To demonstrate the "Requires interface", one of the component, the **Car** component requires the other two - **Engine** & **Light** components. This also shows how we can use **Sequential Composition** as this is another example of reuse. 

###### Components - 

**Engine:** This component implements the provides interface which has 5 abstract methods - start(), stop(), accelarate(), slowDown() and hitBreak().

**Light:** This component implements 3 abstract methods from the provides interface - turnOn(), turnOff() and blink(). 

**Car:** This component requires 4 methods from the aforementioned components - start() & stop() from the Engine component and turnOn() & turnOff() methods from the Light component. This also implements its own start() and stop() method from its provides interface in which it calls the required methods to demonstrate reusability.   