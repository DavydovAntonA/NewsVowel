using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsVowel.Collection
{
    /// <summary>
    /// Коллекция с гласными буквами русского и английского языка
    /// </summary>
    internal class CollectionCharsVowelRuAndEn : CollectionCharsBase
    {
        public CollectionCharsVowelRuAndEn() : base(32)
        {
            Add('а');
            Add('А');
            Add('е');
            Add('Е');
            Add('ё');
            Add('Ё');
            Add('и');
            Add('И');
            Add('о');
            Add('О');
            Add('у');
            Add('У');
            Add('ы');
            Add('Ы');
            Add('э');
            Add('Э');
            Add('ю');
            Add('Ю');
            Add('я');
            Add('Я');

            Add('a');
            Add('A');
            Add('e');
            Add('E');
            Add('i');
            Add('I');
            Add('o');
            Add('O');
            Add('u');
            Add('U');
            Add('y');
            Add('Y');
        }
    }
}
