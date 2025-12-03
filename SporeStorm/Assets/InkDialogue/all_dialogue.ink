VAR hasSasha = false
VAR onScreen = false
VAR hasAccess = false




=== Florida ===
Oh, this is bad. #speaker: Player
This is like, really bad.

What are you even supposed to do? A giant infectious storm, really?
You should probably leave, for starters. Yeah, that sounds like a good plan.
You could find some stuff to bring in your car, too. You don't have much time, by the sound of it - maybe a few hours?
Food is important, but so is water. Fuel, too. You're pretty sure your landlord has some spare gas hidden somewhere in case the power ever goes out.
What to pick...
* [Clean water seems most important. -1 hour] #water:true #hours:1
  You scramble around your apartment, grabbing as many containers you can to fill with water.
  You probably have enough time to grab something else... but what?
  * * [Food should be prioritized. -1 hour] #food:true #hours:1
  * * [Gas will probably be hard to come by. -1 hour] #gas:true #hours:1
* [Food should be prioritized. -1 hour] #food:true #hours:1
  You dig through every cupboard in your apartment, fishing for as much food as you can find.
  You probably have enough time to grab something else... but what?
  * * [Clean water seems most important. -1 hour] #water:true #hours:1
  * * [Gas will probably be hard to come by. -1 hour] #gas:true #hours:1
* [Gas will probably be hard to come by. -1 hour] #gas:true #hours:1
  You sneak downstairs, finding the door to the storage room already open. Most of the supplies have already been cleared out, but you find a full jerrycan left.
  You probably have enough time to grab something else... but what?
  * * [Clean water seems most important. -1 hour] #water:true #hours:1
  * * [Food should be prioritized. -1 hour] #food:true #hours:1

--> END





=== Missouri ===
It's hard to believe the news is real... a giant, infectious storm? That sounds like the plot to some horrible movie. #speaker: Player
* [What's next, zombies?]
* [This whole town is so empty...]
- You look around, gathering your bearings and trying to decide the best course of action. You weren't able to grab much from home...
* [I'm totally going to starve.]
* [Dying of dehydration doesn't sound fun.]
* [When's the last time I got gas?]
- Well, shit.
- Maybe you could collect supplies from around here? It's not like anyone is around to use it anymore.
- Yeah, that's a good idea. But what to look for first? There's only so many hours in the day...
* [Food, definitely. (-3 hours)] #food:true #hours:3
* [Water for sure. (-4 hours)] #water:true #hours:4
* [Can't get anywhere without gas. (-2 hours)] #gas:true #hours:2
- You walk forward more, noticing a lone mechanic waiting outside what appears to be an abandoned garage.
    "What are you still doing here? They sent out the evacuation notice hours ago." #speaker: Jane
    * ["The same could be said about you, y'know."]
    - "Fair enough. What's the problem, anyway? You don't seem to rushed to get out of here." #speaker: Jane
        * ["I just find this all hard to believe. A mutant storm full of spores?"]
            "I wouldn't be too sure about that. I've seen some of the people they've been wheeling across the street, and it looks pretty bad." #speaker: Jane
            "Rashes and blisters all over their face, some of them throwing up everywhere too." #speaker: Jane
        * ["I was on my way out now, just had to get my some things in order before I leave my life behind."]
            "I get it. I've heard it's pretty bad though - seen people around with blisters and rashes all over. Looks... painful."
    - 
    * ["God, that's awful. Maybe the news was right for once. But, if you saw it all, why aren't you leaving?"] #speaker: Player 
        "Can't, the government shut down the buses. I got left here to tough it out."
            * * ["It wouldn't feel right leaving you stranded, can I offer a ride?"]
                "Are you sure? I wouldn't want to be a burden. I've handled a lot in my life, some mushrooms shouldn't be too hard to deal with."
            * * * ["No, please, I insist. No decent human could leave someone else here stranded."] #joining: true
                    "Then I accept. My name's Jane, by the way - figured you might want to know before you let me in your car."  #speaker: Jane
                    * * * * ["Pleasure to meet you Jane. It looks like we've got a long road ahead of us."] #speaker: Player
                    -> END
            * * ["Probably a good idea... I better head out early while I can. Good luck out there."] #speaker: Player
                "Yeah, I get it. No sense in both of us waiting around for something we can't stop."  #speaker: Jane
                * * * ["I'll keep that in mind. Stay safe."] #speaker: Player
                    "You too, kid. Drive safe out there."  #speaker: Jane
                    As you turn around to head back to the car, you think to yourself. Maybe this is bigger than you thought?  #speaker: Player
                    -> END
--> END



=== Mississippi ===
I think I see a gas station up there, might be nice to stop for a few more things. #speaker: Player
As you approach the station, it's nearly deserted. Aside from the clerk inside, and a mother and daughter waiting at the door. 
* ["Excuse me, is this place even open?"]
-
"He's closing the place down now. This whole street has basically been abandoned."#speaker: Laura

* ["Wow that was fast"]#speaker: Player
-
"Are you on your way out of town?"#speaker: Laura

* ["Yes ma'am, packed up some supplies and hit the road." ]#speaker: Player
- "You seem like a responsible person, may I ask you somehting?"#speaker: Laura
* ["I wouldn't consider myself too responsible."]#speaker: Player
* ["Of course, what do you need?"] #speaker: Player
#speaker: Laura
- "My daughter Sasha here, Sasha say hi" 
Sasha peaks out from hiding behind her mom and waves timidly. #speaker: Player
"Unfortuantly I can't take her to the bunker." #speaker: Laura
"I'm.. how do I say this... not on great terms with the law and may not be the best idea for my to show up there." 
* ["Listen, you seem like a nice person but I'm not in a great place to take care of a child across the country." ] #speaker: Player
    "I understand, maybe there will be someone else that comes along. Thank you for your time sir."     #speaker: Laura
    You turn to walk into the gas station, just as the clerk is locking the doors. #speaker: Player 
    Well, guess this is a sign to hit the road. 
    This is such a strange time, you never really know you can trust. 
    ->END
* ["I see, well I can offer her a spot in my car if you would trust that."]
    "Oh goodness, you have no idea what a savior you are." #speaker: Laura
    "Sasha sweetie, this nice person is going to take you to saftey ok?"
    "Bu-but mom... I don't want to leave you.."  #speaker: Sasha
    "I know love, but I will be there to save you soon ok?" #speaker: Laura
    "Take that space book of your's and read that on your way."
    "Goodbye sweetie, I love you"  #joining: true
    ~hasSasha = true
    You watch as she hugs her daughter tightly. Sasha walks over to you with a backpack full of books, she looks slightly dazed.#speaker: Player
    * * [ "Hi Sasha, we are gonna go on a road trip ok!"] #speaker: Player
    -
    * ["I see you're a big fan of astronauts, do you have any fun facts?"]#speaker: Player
    You know you're not great with kids, but you couldn't imagine leaving her here in these conditions.
    You open the car door for her and you both continue on the drive.
    -> END
    
-> END









=== Illinois ===
Never thought I would actually step foot in Illinois, but here we are. There's always a first for everything.# speaker: Player
* ["Excuse me, mister, do you know where I could find the closest gas station?"] 


"Hrmph. I've seen plenty of punks like you coming by here causing all sorts of trouble. *cough cough* Be on your way now."# speaker: Peter


* ["Please sir, I'm just looking for some supplies to help on my drive. I've come from Florida and I'm only about halfway to the bunker."]# speaker: Player
-

"Bunker?! Don't tell me you believe in all this alien nonsense. *cough cough*" #speaker: Peter
"I've seen plenty of these so-called viruses come and go. Haven't gotten me yet, so why should I leave?"


* ["Based on what I've seen myself, I wouldn't be too sure of that. This virus is messing people up bad."] #speaker: Player

    "Nothing a little *cough* medicine can't fix."# speaker: Peter
    -> conversation_continue

* ["Listen, I don't blame you. I don't know how much of this I believe either, but they're closing down the state lines. Everyone has to leave."]# speaker: Player


    "Not me. I'm staying right here with the r- *cough* ... excuse me ... the rest of my farm."# speaker: Peter
    -> conversation_continue

=== conversation_continue ===


* ["I hear ya, man. But anyway, do you know of any gas stations around here?"]# speaker: Player
-


"Not any open within at least an hour. I'll tell ya what though — since I believe we see eye to eye about most things..." # speaker: Peter

"How about you f.. *cough*...follow me up the way to my cabin? I'll let you leave with a few things."

* ["That's awfully generous, but I should really get going. Can't get caught in any more traffic."] # speaker: Player

    "I know that feeling. Well, feel free to look around the street here. People leave things around all the time."# speaker: Peter
    
    * * ["Thank you sir. Are you sure you don't want to hitch a ride to the bunker? I've got more room in the back."]# speaker: Player

        "So the roads really are that bad? I guess it can't be that bad of an idea... *cough cough* I guess I'll hitch a ride. Thanks, man."# speaker: Peter

        * * * [Continue on the drive.]# speaker: Player  #joining: true
            ->END

    * * ["Stay safe out there. I hope the storm doesn't cause too much harm to your farm."]# speaker: Player
        -> END

* ["If you don't mind, that would be great."]# speaker: Player

    "I figured my supplies aren't doing anyone justice just sitting around here doing nothing."# speaker: Peter

    You follow Peter to his cabin. # speaker: Player
    You guys get to talking and as you get to talking, you learn about his love for his farm. 
    Before you realize, 4 hours have already passed!
    You thank Peter for his time and rush back to your car at the end of the road. 
    -> OutOfTime
    "As much as a pain you young folk are, I wish you the best of luck out there."# speaker: Peter
    "I wouldn't want to be out on those roads, but more importantly, I can't leave my crops here alone."
    -> END
    
    
    
    
    
    
    
=== Nebraska === 

"Holy shit this place is like a ghost town."#speaker: Player 
As you approach the closed corner market, you notice a man sitting on the bench all alone.
You roll your window down as you approach. 

* ["Excuse me sir, are you ok out there?"] #speaker: Player 
-

"God is that you?" #speaker: Matt   

* ["No.. over here to your right.. the only car on the road.."]#speaker: Player 
* ["Hey dipship, I'm in the car right next to you."]

- "Oh, I apologize. I'm a little loopy from being out here in the cold." #speaker: Matt


* ["It's ok, what are you doing out here anyway?"]#speaker: Player 
- 

"I was supposed to catch a flight to Idaho to see my family, but of course all the airports shut down so now I'm stuck in who knows where." #speaker: Matt

* ["Ouch thats tough, can't imagine being stuck out here in this weather."]#speaker: Player 

    "I bet the heat in your car feels pretty nice right about now.  #speaker: Matt
    
* ["I'm so sorry, when is the last time you saw them?"]#speaker: Player 
    
    "It's been 4 months. I was on an international work trip when my layover got cancelled. Hmm, just my luck."#speaker: Matt
   

- 
* ["Oh wow."]#speaker: Player 
-

"Sorry, I don't mean to dump all this on you." #speaker: Matt

* ["It's all good, I can imagine you're stressed."] #speaker: Player 
-

"Hey man, I hate to ask this but... do you think I could hitch a ride to Idaho. I have no other option man im desperate." #speaker: Matt


hmm, if I pick this man up I have to drop him off in Idaho. Is it too far out of my way?#speaker: Player 



* ["I don't know if I have any more room in my car man, I'm sorry."]#speaker: Player 
    "No worries man, I totally get it. I am a stranger after all."     #speaker: Matt

    "By the way, there's an abandoned grocery store up here on the corner, I would check it out if you're looking for supplies." 

    * *  ["Thanks man. I should be off now but, stay safe out there!"]#speaker: Player 
        -> N1



* ["Of course you can! No man could leave someone stranded out here in this condition."]#speaker: Player 

    "Oh man, you have no idea how much of a blessing this is. I don't have much to offer, but I have some food for us to share."     #speaker: Matt


    * * ["Anything you have would be of help, thank you."]#speaker: Player 
    
    "By the way, there's an empty grocery store up here on the corner. If we want to stop there I can see what they left behind."     #speaker: Matt


        * * * ["That sounds like a perfect plan."]#speaker: Player 
            "What would you like me to get?"     #speaker: Matt  #joining: true


            * * * * ["Food would be best."]#speaker: Player 
                "Alright, let's hit it."     #speaker: Matt

                ->END
            * * * * ["Definitly some water."]#speaker: Player 
            "Alright, let's hit it."     #speaker: Matt

                    ->END
        * * ["I think it's best if we keep driving for now."]#speaker: Player 
            "Probably a good idea. Well let's hit the road, we have a long drive ahead of us!"    #speaker: Matt


            heh, yeah... "we"...#speaker: Player 
                ->END
    
=== N1 ===
        You slowly drive away from Matt on the corner. You see him look longingly at your car from the rear view mirror. #speaker: Player 
        * [Stop for supplies at the grocery store.] #speaker: Player 
            * * [Food would be best.]#speaker: Player 
            ->END
            * * [Definitly some water.] #speaker: Player 
            -> END
        * [Keep driving.]#speaker: Player 
            I've still got quite a bit to go, let's hit the road.#speaker: Player 
            -> END
    
    


=== NorthDakota ===
Wow, this place kinda reminds me of my old campus. What a small world we live in. #speaker: Player 
You notice an... odd.. looking man running around the grassy field infront of what appears to be the science building. 


"HEY! YOU THERE! Stay back, and I mean it, don't come ANY closer to me." #speaker: Dr. Thompson 


This gut is a nut job I can already tell. #speaker: Player 
* ["Woah woah, I don't mean any harm. I just stumbled across this campus on my drive to the bunker."]

"Bunker you say, where.. the government is. Fascinating... very very fascinating..."#speaker: Dr. Thompson 

* * ["Hey buddy are you ok?"]#speaker: Player 
    ->ND2
* * [Why are you acting so... strange?"]#speaker: Player 
    ->ND2
    
== ND2 ===

"I have a secret to tell you, but you can't tell ANYONE. Not even anyone on that little phone of yours. YOU SWEAR?"#speaker: Dr. Thompson 


* * ["Alright man I swear I swear, whatever you say is safe with me."]#speaker: Player 
    ->ND3
* * ["You're insane, I don't even know you."]#speaker: Player 
    ->ND3

== ND3 ==

"My name is Dr. Shaun Thompson, Ph. D in biotechnology. And today, November 6th, 1995 marks the date I found the cure for the radioactive sporestorm that is threatening North America. #speaker: Dr. Thompson 


* * ["I should really get going now..."]#speaker: Player 

    "Not quite yet my friend, there is still much to discuss."#speaker: Dr. Thompson 

    ->ND4
* * [A cure? That sounds a little too good ot be true don't you think?"]

    "Do you doubt Dr. Thompson?? That's absurd. My spore neautrilizer is by far the most advanced creation the governmetn could ever witness." #speaker: Dr. Thompson 

    ->ND4
    
=== ND4 ==
"If only I could make it back to Washington with this news, I could be the greatest hero of the 20th century." #speaker: Dr. Thompson 



* ["Washington you say?"]#speaker: Player 

- "Well yes, that is where head government bunker is correct? I've been working so hard in my office I didn't even think of how I will get there." #speaker: Dr. Thompson 


* ["Well, I'm on my way there now. Is it something I can take with me?" ]#speaker: Player 

    "OH HEAVENS NO. Tools like these cannot be delivered without a professional like me around. I must accompany you." #speaker: Dr. Thompson 



    * * ["Well doc, if that's the only way then so be it, hop in."]#speaker: Player 
        -> DOCJOIN
    * * ["I think it's probably safest if you stay here, sorry doc."]#speaker: Player 

        "I understand, well, maybe with the leftover parts the physics professors left behind I could create a make shift teleporter. Tally Ho!"#speaker: Dr. Thompson 


        "Alright well just... be safe and uh... dont't burn anything down!"#speaker: Player 
        Huh, well anyways. 
        * * * [I should probably check that shed over there for some gasoline while I'm here.]#speaker: Player 
        -> END
        * * *  [Time to hit the road, I don't want wanna be by this lunatic for any second longer.]#speaker: Player 
        -> END
        
        


* ["If you promise you won't zap me with any of your fancy trinkets, I could let you join me on my drive."]#speaker: Player 
    ->DOCJOIN
    === DOCJOIN=== 

    "Well isn't this a joyous set of events. I shall join you on your journey to Washington State and we shall save the planet!" #speaker: Dr. Thompson 

    "Quick! Let's rummage through the old janitor shed for some extra gasoline. It won't take too long"   #joining: true

    * * [Works for me, I could always benefit from some free gas."]#speaker: Player 
    
    * * ["It's probably best if we hit the road now, don't want to be driving too late."]#speaker: Player 

- "Well Tally Ho! Let's be on our way"#speaker: Dr. Thompson 


What a strange guy, but surely he's trustworthy... right?#speaker: Player 
->END
        
->END









=== SouthDakota === 

I thought nothing could get creepier than the last place, but I stand corrected. #speaker: Player 

Oh and would you look at that, just when I thought thing's couldn get scarier, there's an old women on the porch there.
Let me not be too judgemental. 
* ["Excuse me ma'am, do you know about the evacuation."]#speaker: Player 

"If I hear one more hippie coming in here running their mouth..."#speaker: Carol


* * ["That's very rude to say to someone who is just offering to help."]#speaker: Player 


    "Help with what? This is God's plan all along, im exactly where he wants me to be." #speaker: Carol


    * * * ["I'm sorry, did you say.... Gods plan?"]#speaker: Player 
    -> SD1
    
    
* * ["I come in peace ma'am, I promise I'm just passing through."]#speaker: Player

    "Only time I'll have any peace is when this rapture comes and takes me there." #speaker: Carol


    * * * ["Im sorry, did you say.. rapture?"]#speaker: Player 

    -> SD1
=== SD1 ===

"Well yes precisley" #speaker: Carol

"Last sunday Pastor John said that soon there would be a sign from God that proves you are exactly where you need to be."
"And then the following week I hear about this storm spore that's causing a ruckuss. I'll tell you what this is.. it's Gods Rapture!" 

* ["Ma'am, I think it may be a good idea to take you somewhere safe, I don't think you're thinking clearly."]#speaker: Player 


    "Oh I am thinking very clearly. In fact, this is probably the clearest I've ever thought in my whole life." #speaker: Carol

* ["Ok it's official, I think you're the craziest one I've met so far."]#speaker: Player 


    "You're laughing now, but it wont be funny still when those clouds above you part ways and God's hand is reaching out to save his children." #speaker: Carol


-
* ["Yeah?"] #speaker: Player 
-


"I have spent years practicing my religion and that does not stop when the government tell's me to." #speaker: Carol


* ["No one's telling you to stop, but maybe it would be a good idea to go to the bunker so you can meet other people with the same ideas."]#speaker: Player 


    "Like I said, only god can tell me what to do and you're not him! If god wants me to go to the bunker he would have told me by now."#speaker: Carol


    * * ["Funny you say that, God actually just told me he wanted you to come to the bunker with me."] #speaker: Player 


        "Wait.. god told you that?" #speaker: Carol


        * * * ["Yeah, it's true! I'm on my way to the bunker now if you'd like to join me there."]#speaker: Player 


        "Well if that's what god wants, that's what is best for me. I shall join you on the rest of the journey."#speaker: Carol


        I know this was the right choice, but oh am I in for a long ride....#speaker: Player  #joining: true

        ->END
    * * [ "Alright well... if that's what god want's then that's what's gonna happen."]#speaker: player 

        * * * ["I wish you a good life here at this doorstep, don't drive yourself too mad."]#speaker: player 


        "MAD? I'll show you mad" #speaker: Carol


        You rush back to your car before she can catch up. You drive off knowing that she probably won't be the craziest one you'll meet on this journey..."  #speaker: Player 

        ->END
    
* ["I think you might be a lost cause."]#speaker: player 


"LOST CAUSE? I'll show you a lost cause." #speaker: Carol

You rush back to your car before she can catch up. You drive off knowing that she probably won't be the craziest one you'll meet on this journey..." #speaker: player 


->END






=== Wyoming ===
{ hasSasha: 
-> WyomingWithSasha
 - else: 
 -> WyomingWithoutSasha
 
}







=== WyomingWithSasha === 
Wow... I've never been to Yellow Stone before. It's quite beautiful actually.#speaker: Player

Who knew a deadly storm is what would have brought me here...

"Hey! You There! Don't come any closer to me with that radio of yours!"#speaker: Ezekial 

"The frequencies are gonna tell them exactly where I am!"

* ["Frequencies? From a damn radio..."]#speaker: Player

-


"Well you see, the government has been playing around with this new thing called 5G, they say it's supposed to be the biggest and brightest new thing, but I don't belive it for just one minute." #speaker: Ezekial 


* ["You sure talk a lot don't you mister."] #speaker: Player

* ["I can't believe I ran into another crazy."] #speaker: Player


- "People always say I'm crazy, but I think crazy is exciting. You should've seen the fun my daughter and I had before her mom called me crazy." #speaker: Ezekial 


*  ["Oh man, I'm so sorry. That must be very difficult."]#speaker: Player

*  ["I can see why she said that."]#speaker: Player


    - "Oh Sasha, if only I could see her one more time before this storm takes us all." #speaker: Ezekial 


            * ["Wait did you say Sasha? That's such a coincidence."]#speaker: Player

            -
            * ["I'm taking care of this young girl right now her name is Sasha."]#speaker: Player

            -
            You point to the girl in your backseat, here eyes are just barely visible out the window when you see her face light up.

            "This can't be real! How did you manage to find my daughter! She lives with her mother in Mississippi."#speaker: Ezekial 


            * * * ["How can you be sure that's your daughter?"]#speaker: Player

                -> W1
            * * * ["Mississipi you say? That's exactly where her mother left her with me."] #speaker: Player

                -> W1
            === W1 ===

            "I know those eyes from anywhere, she looks just like her mother." #speaker: Ezekial 


            you watch as Sasha rushes from the car and jumps into her fathers arms.#speaker: Player


            "Oh sasha dear how I've missed you, all these adventures I've had to go on without you!"#speaker: Ezekial 


            * ["If this is true, you must come with us to the bunker with your daughter."]#speaker: Player


                "Oh this is the happiest day of my life! I'm reunited with my sweet girl and saved by this random person with their toxic radio box." #speaker: Ezekial   #joining: true

                "I'll tell you what stranger, a good friend of mine has a private bunker in Arizona, if you can get us there I'll make sure we all get in. 

                A private bunker? In arizona?? Am I really gonna trust this guy? #speaker: Player

                * * ["Ok well, you have to get in my so-called toxic radio box if we are going to make it to saftey." ]
                -
                You watch as Ezekial picks up Sasha and rushes her to the backseat. 
                ~ hasAccess = true
                Guess I have another passenger... 
                ->END
            * ["I'm sorry to break up this special moment, but I was given special instructions by her mother to take her to saftey, I can't let her down now." ]

                "I understand, I only want what's best for her. I know that's where she'll be the safest." #speaker: Ezekial 

                "Not for me though! I must stay here where the signals can't reach me!" 
                "Goodbye Sasha and random person I just met!"

                You watch as Ezekial hugs his daughter tightly before rushing back to his tent. #speaker: Player

                What a strange world we live in, you think to yourself as you walk Sasha back to the car.
                -> END
            


=== WyomingWithoutSasha === 

* ["Wow... I've never been to Yellow Stone before. It's quite beautiful actually."]#speaker: Player

* * ["Who knew a deadly storm is what would have brought me here..."]
    #speaker: Player
    "I can't imagine anyone being at a state park during a government shutdown." 
    * * * ["A little walk through the park never hurt anyone, might be good to get some fresh air."]
        You take a walk through the park
        As you lose track of time... you notice the storm approaching at a steady speed. 
        You turn around... which path did you take... left... or right...
        ->OutOfTime
    * * *  ["It's probably best to not stop for long."]
        * * * * ["Maybe I can pick up some food from that vending machine over there."]
                You grab some snacks to hold you over and then tread back to your car. 
        -> END
 

-> END










=== Utah ===
I know travis is around here somewhere. His cabin should be right around here. #speaker: Player

"Yo! Bro! Over here man!" #speaker: Travis

"I've been stranded here for AGESS, I thought you forgot about me!"


* ["No one could forget you Travis."]#speaker: Player

* ["You have no idea the journey I've been on so far."]#speaker: Player


- "You're telling me man, driving myself crazy over here. No signal, no car, no ladies... what's a guy supposed to do!"#speaker: Travis


* ["Well let's not get too comfortable, we should probably keep this drive going."]#speaker: Player


- "Now hold on man, you just got here! Come inside we'll grab a few things. We've got so much to catch up on."  #speaker: Travis


* ["Alright well let's be fast, we don't wanna waste too much time."]#speaker: Player

* ["I guess a little break never hurt no one, and I have been driving non-stop."]#speaker: Player


- "That's the spirit man! I've got one last pack of brewskies we should finish before taking off."  #speaker: Travis


* ["Ok, one beer then we are leaving."]#speaker: Player


    "More for me!"#speaker: Travis


    You get to catching up with Travis... turns out a lot has happened since his frat days in college. #speaker: Player

    .......
    You glance at your watch..
    * * ["TRAVIS. It's 6pm already."]
    You look outside the window... the storm is nearly at your door.
    You attempt to make a run for your car.
    -> OutOfTime
    
* [No drinking for me man, we gotta stay sharp with everything going on."]#speaker: Player

    You follow Travis into his cabin, the whole place has been trashed. 
    * * ["Travis c'mon, what happened to the place?"]

        "This is what happens when you're stranded in a cabin alone for 4 days with enough beer to kill an army."  #speaker: Travis

        ->U1
    * * ["Oh wow, this place bring back some memories."] #speaker: Player


        "Lot's of summers spent here remember buddy?"#speaker: Travis

        -> U1
=== U1 ===

* ["Alright man as much as I miss this place, we have got to get on the road."]#speaker: Player

* * ["I've made it this far I'm not gonna stop now."] #speaker: Player


"Ok let me pack up my snacks and I'll meet you out front." #speaker: Travis  #joining: true


Travis is great but, he get distracted easily... #speaker: Player

As you're nearing your car you hear the cabin door open behind you.

"Hey man! Good news! I found another pack of IPA's out back!" #speaker: Travis


Oh man... #speaker: Player



-> END













=== Washington ===
#speaker: Player
After sitting in traffic for hours, you finally make it to the gates. 
Swat members are swarming the area.
Wow, it really looks like an apocolypse in here.
It's crazy to think I just drove across the whole country.
I ran into so many strange people...
You aproach the gate agent, he informs you to park in the field, leave anything except water, food, and medication, and make your way to the elevators.
You take a deep breath and realize... you survived.
For now. 
->END





=== Idaho ===
As you approcah the bus stop, you see a teenage boy sitting on the bench smoking a cigarette.#speaker: Player
"Hey man, I don't know if you've heard but all the busses are shutdown. Evacuation order." 

"Oh piss off, you sound just like my mother."  #speaker: Connor

* ["Well I hope you don't talk to your mother like that."]#speaker: player 
* ["You seem like a real joy don't you."]#speaker: player 

- "Can't a guy catch a break and smoke in peace." #speaker: Connor
* ["You really shouldn't be smoking, kill's your lungs."] #speaker: Player
* ["If you wan't me to leave you be you can say it nicely."] #speaker: Player

- "Alright, then why are you still here?" #speaker: Connor

Something about this kid seem's so familiar. #speaker: Player
He almost acts exactly how I did at that age. 
* ["Ya know, I used to smoke too at your age]
-
"And that's my problem because?" #speaker: Connor


* ["Because I know what you're doing—pretending you don't care. I did that too."] #speaker: Player

    "Yeah? And look how great that turned out." #speaker: Connor
    "When everyone acts like the world's ending, someone has to pretend it’s not." #speaker: Connor
    "You gonna tell me to come with you or something?"

    * * ["I'm telling you I don't want to leave you here alone."] #speaker: Player

        "…You're weird, you know that?" #speaker: Connor

        "Fine. Whatever. I'll walk with you. Just stop giving me that… adult responsibility look." #speaker: Connor
        ->END

    * * ["No. I'm giving you the choice. Stay, or come with me."] #speaker: Player

        "You really suck at this whole persuasion thing." #speaker: Connor

        "…But sitting here sulking won’t do me any favors." #speaker: Connor

        "Alright, alright. I’m coming."
        ->END

* ["Because someone cared enough to tell me to stop before I wrecked myself. Maybe you need that too."] #speaker: Player

    "You don’t even know me." #speaker: Connor
    "But…"
    He stares down at his cigarette, almost embarrassed.
    "Look, I’m not trying to be a jerk. I just… don’t like being told what to do." #speaker: Connor

    * * ["Trust me, I was the same way. Come on. We can talk on the way."] #speaker: Player

            "You’re really not gonna let this go, huh?" #speaker: Connor

            "Fine. Lead the way."
            ->END

    * * ["Then don’t think of it as being told what to do. Think of it as not dying in a stupid way."] #speaker: Player

            "…Fair point." #speaker: Connor

            "Alright, I’ll go. Just stop lecturing."
            ->END

* ["Because I’d rather not watch someone who reminds me of myself get swallowed by the storm."] #speaker: Player

        He pauses, suddenly quieter. #speaker: Connor
        "You… think I’m like you?" #speaker: Connor
        "Well you wouldn't want two of you in one car then, HA."
        "Do yourself a favor and just turn the car around." 
        You walk away defeatedly, sometime's there is just nothing you can do. #speaker: Player
        "Make sure to head TOWARDS the big red storm in the sky HAHAHA." #speaker: Connor
        ->END
->END





=== Arizona ===
{ hasAccess: 
-> ArizonaWithAccess
 - else: 
 -> ArizonaWithoutAccess
 
}

=== ArizonaWithAccess    ===
"Just park up here to the left, we can walk to where we need to go." #speaker: Ezekial  
You get your belongings out of the trunk and look around. #speaker: Player
We are quite literally in the middle of nowhere...
How on earth is there supposed to be a bunker here.
Before you have a moment to think, Ezekial is rushing with Sasha and waving for you to follow.
"FASTER MAN, we don't have all day!!" #speaker: Ezekial
Oh god, this man really is crazy. I'm gonna die here. #speaker: Player 

It's crazy to think I just drove across the whole country. Just to die next to a man named Ezekial. #speaker: Player 
I ran into so many strange people...
Wait... there's actually a guard over here.
You aproach the gate agent, he informs leave anything except water, food, and medication, and make your way to the elevators.
You take a deep breath and realize... you survived.
For now. 
->END



->END

===ArizonaWithoutAccess===
Wait a minute, is this... Arizona?? #speaker: Player 
I've gone completly out of the way. 
This isn't good at all. 
You're looking around for a way to turn around, when you look up at the sky....
-> OutOfTime





=== OutOfTime ===
You freeze in place, realizing suddenly that the spores in the air are multiplying at a frightening rate. You can feel the spores entering your body. #speaker: Player 
- #gameover: true
--> END






