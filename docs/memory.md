# Memory Basics – Struct vs Class

## Experiment
- 10,000,000 iterations
- .NET 8

## Observation
- Struct allocation is near zero
- Class allocation grows linearly

## Conclusion
Structs are stack-allocated (when possible).
Classes are always heap-allocated.
