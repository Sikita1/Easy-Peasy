using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class True : MonoBehaviour
{
    public int Score;
    public Text score;
    public Text achiev;
    public GameObject Error1;

    void Update()
    {
        score.text = Score.ToString();
        if (Score >= 0 && Score <= 4)
        {
            achiev.text = "Тупик (";
        }
        else if (Score >= 5 && Score <= 8)
        {
            achiev.text = "Тефтелька";
        }
        else if (Score >= 9 && Score <= 12)
        {
            achiev.text = "Тыковка";
        }
        else if (Score >= 13 && Score <= 16)
        {
            achiev.text = "Хлебушек";
        }
        else if (Score >= 17 && Score <= 20)
        {
            achiev.text = "Свинка Пеппа";
        }
        else if (Score >= 21 && Score <= 24)
        {
            achiev.text = "Ибрагим";
        }
        else if (Score >= 25 && Score <= 28)
        {
            achiev.text = "Кренделёк";
        }
        else if (Score >= 29 && Score <= 32)
        {
            achiev.text = "Принцесса";
        }
        else if (Score >= 33 && Score <= 36)
        {
            achiev.text = "Утреннее яичко";
        }
        else if (Score >= 37 && Score <= 40)
        {
            achiev.text = "Ватрушечка";
        }
        else if (Score >= 41 && Score <= 44)
        {
            achiev.text = "Гаечка";
        }
        else if (Score >= 45 && Score <= 48)
        {
            achiev.text = "Ведьмочка";
        }
        else if (Score >= 49 && Score <= 52)
        {
            achiev.text = "Острый перчик";
        }
        else if (Score >= 53 && Score <= 56)
        {
            achiev.text = "Смурфик";
        }
        else if (Score >= 57 && Score <= 60)
        {
            achiev.text = "Ванильный сырок";
        }
        else if (Score >= 61 && Score <= 64)
        {
            achiev.text = "Бурундучек";
        }
        else if (Score >= 65 && Score <= 68)
        {
            achiev.text = "Булочка";
        }
        else if (Score >= 65 && Score <= 68)
        {
            achiev.text = "Пухлый пингвинчик";
        }
        else if (Score >= 69 && Score <= 72)
        {
            achiev.text = "Сосиска";
        }
        else if (Score >= 73 && Score <= 76)
        {
            achiev.text = "Солённый огурчик";
        }
        else if (Score >= 77 && Score <= 80)
        {
            achiev.text = "Суслик";
        }
        else if (Score >= 81 && Score <= 84)
        {
            achiev.text = "Сникерс";
        }
        else if (Score >= 85 && Score <= 88)
        {
            achiev.text = "Вареничек";
        }
        else if (Score >= 89 && Score <= 92)
        {
            achiev.text = "Вкусная сордэлька";
        }
        else if (Score >= 93 && Score <= 96)
        {
            achiev.text = "Бегемотик";
        }
        else if (Score >= 97 && Score <= 100)
        {
            achiev.text = "Карамелька";
        }
        else if (Score >= 101 && Score <= 104)
        {
            achiev.text = "Воробушек";
        }
        else if (Score >= 105 && Score <= 108)
        {
            achiev.text = "Макарошка";
        }
        else if (Score >= 109 && Score <= 112)
        {
            achiev.text = "Пельмешек";
        }
        else if (Score >= 113 && Score <= 116)
        {
            achiev.text = "Бэтмен";
        }
        else if (Score >= 117 && Score <= 120)
        {
            achiev.text = "Белоснежка";
        }
        else if (Score >= 121 && Score <= 124)
        {
            achiev.text = "Ёжичек";
        }
        else if (Score >= 125 && Score <= 128)
        {
            achiev.text = "Маленький пупсик";
        }
        else if (Score >= 129 && Score <= 132)
        {
            achiev.text = "Спелая вишенка";
        }
        else if (Score >= 133 && Score <= 136)
        {
            achiev.text = "Помидорка";
        }
        else if (Score >= 137 && Score <= 140)
        {
            achiev.text = "Котёнок";
        }
        else if (Score >= 141 && Score <= 144)
        {
            achiev.text = "Милая черепашка";
        }
        else if (Score >= 145 && Score <= 148)
        {
            achiev.text = "Мандаринка";
        }
        else if (Score >= 149 && Score <= 152)
        {
            achiev.text = "Пельмешек";
        }
        else if (Score >= 153 && Score <= 156)
        {
            achiev.text = "Комочек счастья";
        }
        else if (Score >= 157 && Score <= 160)
        {
            achiev.text = "Симпотяжка";
        }
        else if (Score >= 161 && Score <= 164)
        {
            achiev.text = "Сладкий пончик";
        }
        else if (Score >= 165 && Score <= 168)
        {
            achiev.text = "Эротичный эльф";
        }
        else if (Score >= 169 && Score <= 172)
        {
            achiev.text = "Мармеладка";
        }
        else if (Score >= 173 && Score <= 176)
        {
            achiev.text = "Зефирка";
        }
        else if (Score >= 177 && Score <= 180)
        {
            achiev.text = "Безумно хорош";
        }
        else if (Score >= 181 && Score <= 184)
        {
            achiev.text = "Шоколадный кексик";
        }
        else if (Score >= 185 && Score <= 188)
        {
            achiev.text = "Шлемпампумчек";
        }
        else if (Score >= 189 && Score <= 192)
        {
            achiev.text = "Пирожочек";
        }
        else if (Score >= 193 && Score <= 196)
        {
            achiev.text = "Уфф какой";
        }
        else if (Score >= 197 && Score <= 199)
        {
            achiev.text = "Аппетитненькая вкусняжка";
        }
        else if (Score == 200)
        {
            achiev.text = "Мастер Easy Peasy";
            Error1.SetActive(true);
        }
    }
}
