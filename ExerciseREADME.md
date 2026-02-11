# Technical Evaluation – Vertical Slice Exercise

## Overview

In this exercise, you will implement a small vertical slice in an existing Clean Architecture solution.

The goal is not speed or polish.  
We are interested in how you:

- Plan and structure a feature
- Work within architectural boundaries
- Model domain logic
- Write appropriate tests
- Reason about tradeoffs

Please talk through your thinking as you work.

---

## The Feature: Performance Tier Evaluation

Implement a feature that evaluates performance based on two inputs.

### Requirements

1. Accept two numeric inputs:
   - `throughput`
   - `efficiency`

2. Calculate a performance score:

- score = throughput \* efficiency

3. Assign a performance tier based on the score:

| Score Range | Tier       |
| ----------- | ---------- |
| < 100       | Basic      |
| 100–499     | Standard   |
| 500+        | Enterprise |

4. Persist the evaluation result.
5. Return the calculated score and assigned tier.

---

## Architectural Expectations

- Respect the existing Clean Architecture boundaries.
- Keep domain logic in the appropriate layer.
- Avoid leaking infrastructure concerns into domain models.
- Keep the solution simple and pragmatic.

---

## Testing Expectations

Include appropriate tests.

Consider:

- Score calculation correctness
- Tier boundary conditions (e.g., 99, 100, 499, 500)
- Core domain behavior

---

## Additional Guidance

- Assume tier thresholds may need to change in the future.
- Do not over-engineer the solution.
- Keep abstractions proportional to the problem.
- If something is unclear, ask.

---

## Time Expectation

Approximately 60–90 minutes.

---

## Running the Project

### Build

```bash
dotnet build
```

## What We’re Evaluating

We are evaluating:

- Architectural reasoning

- Modeling decisions

- Code clarity

- Test quality

- Communication

- Tradeoff awareness

There is no single “correct” implementation.

- We are more interested in how you think than in whether you complete every detail.
