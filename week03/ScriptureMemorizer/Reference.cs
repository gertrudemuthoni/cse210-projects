using System;
using System.Collections.Generic;   
using System.Linq;

class Reference
{
 private string _book;
 private int _chapter;
private int _startverse;
private int? _endverse;
public Reference(string book, int chapter, int startverse, int? endverse = null)
{
_book = book;
_chapter = chapter;
_startverse = startverse;
_endverse = endverse;
}
    public override string ToString() => _endverse == null ? $"{_book} {_chapter}:{_startverse}" : $"{_book} {_chapter}:{_startverse}-{_endverse}";
}