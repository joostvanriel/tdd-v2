# Cruise control #
A cruise control system was built for a customer. The system consists of two classes:

- CruiseControl: which contains the business logic for the cruise control system.
- Hardware: which has methods to directly control and read the hardware in the car.

When the cruise control system is enabled, it will instruct the hardware to accelerate to the desired cruise control speed.

One very important requirement was missed though. When a driver presses the break or clutch pedal, the cruise control system needs to be disabled.

You need to implement this new requirement urgently, but you have to make sure that no existing requirements are broken.

Unfortunately the developer before you did not make any unit tests. You will have to write them to make sure nothing gets broken. Only then are you allowed the add new requirements.

Note: it is allowed to change the existing code slightly so that it becomes better testable.