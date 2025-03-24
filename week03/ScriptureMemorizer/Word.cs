using System;
class Word
{
    private string _text;   
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;   
    }

    public void Hide() => _isHidden = true;
    public bool isHidden => _isHidden;
    public override string ToString() => _isHidden ? new string('_', _text.Length) : _text;
}  
