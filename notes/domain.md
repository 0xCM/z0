
## Sequences

* A data type is a *collection* if it can be partitioned into homogenous *cells* or *elements*
* A *stream* is an iterable collection with unknown cardinality with content that is computed on-demand
* A *collection* is *sequential* or a *sequence* if its cells can be traversed with a finte sequence of n natural numbers 0,1,..n-1.
* A sequence is *aligned* or *blocked* if its cells can be evenly partitioned into a sequence of subsequences each of which have the same number of elements


```nomnoml
[<frame>Decorator pattern|
  [<abstract>Component||+ operation()]
  [Client] depends --> [Component]
  [Decorator|- next: Component]
  [Decorator] decorates -- [ConcreteComponent]
  [Component] <:- [Decorator]
  [Component] <:- [ConcreteComponent]
]
```