# C# Attribute Examples

This repository demonstrates the use of custom attributes and reflection in C# by implementing specific examples for educational purposes.

## Task Descriptions

### Task 2: `ObsoleteAttributeExample`

Create a class and apply the `Obsolete` attribute to its methods in two ways:
1. First, apply it with a warning message.
2. Then, apply it in a way that prevents the code from compiling.
Showcase how the `Obsolete` attribute works by calling the methods with different attribute settings.

---

### Task 3: `ObsoleteWithReflectorExample`

Enhance the reflector program from a previous lesson with the following features:
1. **Selection of Type Members**: Allow users to select which type members (e.g., methods, properties) they want to view. It should be possible to select multiple member types at once.
2. **Attribute Information Display**: Add the ability to display information about the attributes for both types and all members that can be decorated with attributes.

---

### Task 5: `AccessLevelAttributeExampleApp`

Create a custom attribute named `AccessLevelAttribute` to define the access level of a user in the system.
1. Design a staff hierarchy for a company, with classes like `Manager`, `Programmer`, and `Director`.
2. Use `AccessLevelAttribute` to assign different access levels to the staff members.
3. Demonstrate system behaviour by displaying a response when each staff member tries to access a restricted section.

---

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/AttributeExamples.git
   ```

2. Open the project in Visual Studio or your preferred C# IDE.
3. Build and run each task solution individually to see the attribute implementations in action.

### Notes
Task 2: Use of ObsoleteAttribute helps demonstrate deprecated code warnings and compile-time errors.

Task 3: Reflection techniques allow dynamic inspection of type members and their attributes.

Task 5: Custom attributes like AccessLevelAttribute simulate access control in a system with different access levels for various employee roles.
