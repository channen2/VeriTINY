# Team README - Post Demo Information 

# Post Demo Additions

1. Updated Types 
   * `GeneralNet` removed and replaced with `SimNetInfo` 
   * `Connection` removed and replaced with `SimBlock`
2. Added bracket support
   * Example: `assign out = ~(a & b)`
3. Added XOR support to basic operators
   * Example: `assign out = a ^ b`
   * Example: `xor x1 (out, a, b)`


# Module Interfaces 

![interfaces](https://github.com/ImperialCollegeLondon/hlp2020-verilog2/blob/master/team/readme-screenshots/module-interfaces.png)


# Demos 
This section contains pre-written verilog files along with their respective block diagrams that can be used in VeriTINY

1. [Simple 1-bit AND Gate](https://github.com/ImperialCollegeLondon/hlp2020-verilog2/blob/master/team/demo-files/and_gate.v)

![demo1](https://github.com/ImperialCollegeLondon/hlp2020-verilog2/blob/master/team/readme-screenshots/andgate.png)

2. [4 Bit Shift Register](https://github.com/ImperialCollegeLondon/hlp2020-verilog2/blob/master/team/demo-files/shift_reg_next_state.v)

![demo2](https://github.com/ImperialCollegeLondon/hlp2020-verilog2/blob/master/team/readme-screenshots/shiftregister.png)

3. [DECA Lab 4 FSM](https://github.com/ImperialCollegeLondon/hlp2020-verilog2/blob/master/team/demo-files/deca4-fsm.v) 

![transitionTable](https://github.com/ImperialCollegeLondon/hlp2020-verilog2/blob/master/team/readme-screenshots/stateTransitionTable.png)

![demo3](https://github.com/ImperialCollegeLondon/hlp2020-verilog2/blob/master/team/readme-screenshots/deca4fsm.png)

4. [Twos Complement Adder Subtractor](https://github.com/ImperialCollegeLondon/hlp2020-verilog2/blob/master/team/demo-files/adder_subtractor.v) 

Information on this circuit can be found [here](http://www.yilectronics.com/Courses/ENGR338L/ENGR338L_2017f/StudentLabs/htregillus/FinalProject.html)

![demo4](https://github.com/ImperialCollegeLondon/hlp2020-verilog2/blob/master/team/readme-screenshots/adder-subtractor.png)

# Possible Improvements

* Expand language support​
  * Literals ​
  * Assign ​
  * ~Brackets~
* ~Connections Type​~
* ~GeneralNet Type​~
* Saving of block level connections + simulation results
* Block diagram UI​
  * Drag and drop blocks​
  * Form connections by clicking ​
  * Show connections being formed (likely use a library)​
* Simulation UI
  * Show waveforms​
  * Scripting language for simulation inputs