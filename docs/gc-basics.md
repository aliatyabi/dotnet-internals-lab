# GC Internals

## GC Roots
Objects reachable from roots are alive.

## Generations
- Gen 0: short-lived
- Gen 1: transition
- Gen 2: long-lived

## Key Insight
GC is reachability-based, not scope-based.
