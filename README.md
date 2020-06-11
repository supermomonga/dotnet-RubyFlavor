[![Build Status](https://travis-ci.org/supermomonga/dotnet-RubyFlavor.svg?branch=master)](https://travis-ci.org/supermomonga/dotnet-RubyFlavor)

# RubyFlavor

RubyFlavor is a .NET Standard library which provides Ruby programming language flavored utilities.

## Implementation statuses

### Enumerable module

- [Enumerable#all?](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/all=3f.html) -> `IEnumerable#All` exists.
- [Enumerable#any?](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/any=3f.html) -> `IEnumerable#Any` exists.
- [X] [Enumerable#chunk](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/chunk.html)
- [ ] [Enumerable#chunk_while](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/chunk_while.html)
- [ ] [Enumerable#collect](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/collect.html)
- [Enumerable#map](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/map.html) -> `IEnumerable#Select` exists.
- [ ] [Enumerable#collect_concat](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/collect_concat.html)
- [ ] [Enumerable#flat_map](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/flat_map.html)
- [ ] [Enumerable#count](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/count.html)
- [ ] [Enumerable#cycle](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/cycle.html)
- [ ] [Enumerable#detect](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/detect.html)
- [ ] [Enumerable#find](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/find.html)
- [ ] [Enumerable#drop](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/drop.html)
- [ ] [Enumerable#drop_while](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/drop_while.html)
- [X] [Enumerable#each_cons](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/each_cons.html)
- [ ] [Enumerable#each_entry](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/each_entry.html)
- [ ] [Enumerable#each_slice](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/each_slice.html)
- [ ] [Enumerable#each_with_index](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/each_with_index.html)
- [ ] [Enumerable#each_with_object](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/each_with_object.html)
- [ ] [Enumerable#entries](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/entries.html)
- [ ] [Enumerable#to_a](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/to_a.html)
- [ ] [Enumerable#find_all](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/find_all.html)
- [Enumerable#select](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/select.html) -> `IEnumerable#Where` exists.
- [ ] [Enumerable#find_index](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/find_index.html)
- [Enumerable#first](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/first.html) -> `IEnumerable#First` exists.
- [ ] [Enumerable#grep](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/grep.html)
- [ ] [Enumerable#grep_v](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/grep_v.html)
- [ ] [Enumerable#group_by](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/group_by.html)
- [ ] [Enumerable#include?](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/include=3f.html)
- [ ] [Enumerable#member?](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/member=3f.html)
- [ ] [Enumerable#inject](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/inject.html)
- [ ] [Enumerable#reduce](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/reduce.html)
- [ ] [Enumerable#lazy](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/lazy.html)
- [ ] [Enumerable#max](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/max.html)
- [ ] [Enumerable#max_by](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/max_by.html)
- [ ] [Enumerable#min](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/min.html)
- [ ] [Enumerable#min_by](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/min_by.html)
- [ ] [Enumerable#minmax](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/minmax.html)
- [ ] [Enumerable#minmax_by](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/minmax_by.html)
- [ ] [Enumerable#none?](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/none=3f.html)
- [ ] [Enumerable#one?](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/one=3f.html)
- [ ] [Enumerable#partition](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/partition.html)
- [ ] [Enumerable#reject](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/reject.html)
- [ ] [Enumerable#reverse_each](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/reverse_each.html)
- [ ] [Enumerable#slice_after](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/slice_after.html)
- [ ] [Enumerable#slice_before](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/slice_before.html)
- [ ] [Enumerable#slice_when](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/slice_when.html)
- [ ] [Enumerable#sort](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/sort.html)
- [ ] [Enumerable#sort_by](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/sort_by.html)
- [ ] [Enumerable#take](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/take.html)
- [ ] [Enumerable#take_while](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/take_while.html)
- [ ] [Enumerable#to_h](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/to_h.html)
- [ ] [Enumerable#zip](https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/zip.html)

### Enumerator class

- [ ] [Enumerator#each](https://docs.ruby-lang.org/ja/latest/method/Enumerator/i/each.html)
- [ ] [Enumerator#feed](https://docs.ruby-lang.org/ja/latest/method/Enumerator/i/feed.html)
- [ ] [Enumerator#next](https://docs.ruby-lang.org/ja/latest/method/Enumerator/i/next.html)
- [ ] [Enumerator#next_values](https://docs.ruby-lang.org/ja/latest/method/Enumerator/i/next_values.html)
- [ ] [Enumerator#peek](https://docs.ruby-lang.org/ja/latest/method/Enumerator/i/peek.html)
- [ ] [Enumerator#peek_values](https://docs.ruby-lang.org/ja/latest/method/Enumerator/i/peek_values.html)
- [ ] [Enumerator#rewind](https://docs.ruby-lang.org/ja/latest/method/Enumerator/i/rewind.html)
- [ ] [Enumerator#size](https://docs.ruby-lang.org/ja/latest/method/Enumerator/i/size.html)
- [X] [Enumerator#with_index](https://docs.ruby-lang.org/ja/latest/method/Enumerator/i/with_index.html)
- [ ] [Enumerator#with_object](https://docs.ruby-lang.org/ja/latest/method/Enumerator/i/with_object.html)

### Integer class

- [X] [Integer#upto](https://docs.ruby-lang.org/ja/latest/method/Integer/i/upto.html)
- [X] [Integer#downto](https://docs.ruby-lang.org/ja/latest/method/Integer/i/downto.html)

### Others

- [ ] [Object#tap](https://docs.ruby-lang.org/ja/latest/method/Object/i/tap.html)
- [ ] [Object#yield_self](https://docs.ruby-lang.org/ja/latest/method/Object/i/yield_self.html)
