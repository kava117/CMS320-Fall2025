-> Mississippi

-> Florida
VAR onScreen = false

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
    - * ["God, that's awful. Maybe the news was right for once. But, if you saw it all, why aren't you leaving?"]
        "Can't, the government shut down the buses. I got left here to tough it out."
            * * ["It wouldn't feel right leaving you stranded, can I offer a ride?"]
                "Are you sure? I wouldn't want to be a burden. I've handled a lot in my life, some mushrooms shouldn't be too hard to deal with."
            * * * ["No, please, I insist. No decent human could leave someone else here stranded."] #joining: true
                    "Then I accept. My name's Jane, by the way - figured you might want to know before you let me in your car."
                    * * * * ["Pleasure to meet you Jane. It looks like we've got a long road ahead of us."]
                    -> END
            * * ["Probably a good idea... I better head out early while I can. Good luck out there."]
                "Yeah, I get it. No sense in both of us waiting around for something we can't stop."
                * * * ["I'll keep that in mind. Stay safe."]
                    "You too, kid. Drive safe out there."
                    * * * * [As you turn around to head back to the car, you think to yourself. Maybe this is bigger than you thought?]
                    -> END
--> END


=== Mississippi ===
#speaker: Player
I think I see a gas station up there, might be nice to stop for a few more things.
As you approach the station, it's nearly deserted. Aside from the clerk inside, and a mother and daughter waiting at the door. 
"Excuse me, is this place even open?"
#speaker: Laura
"He's closing the place down now. This whole street has basically been abandoned."
#speaker: Player
* ["Wow that was fast"]
#speaker: Laura
- "Are you on your way out of town?"
#speaker: player 
* ["Yes ma'am, packed up some supplies and hit the road."]
#speaker: Laura
- "You seem like a responsible person, may I ask you somehting?"
#speaker: Player 
* ["I wouldn't consider myself too responsible."]
* ["Of course, what do you need?" ]
#speaker: Laura
- "My daughter Sasha here, Sasha say hi" 
#speaker: Player
Sasha peaks out from hiding behind her mom and waves timidly. 
#speaker: Laura
"Unfortuantly I can't take her to the bunker." 
"I'm.. how do I say this... not on great terms with the law and may not be the best idea for my to show up there." 
#speaker: Player
* ["Listen, you seem like a nice person but I'm not in a great place to take care of a child across the country."]
    #speaker: Laura
    "I understand, maybe there will be someone else that comes along. Thank you for your time sir." 
    #speaker: Player 
    You turn to walk into the gas station, just as the clerk is locking the doors. 
    Well, guess this is a sign to hit the road. 
    This is such a strange time, you never really know you can trust. 
    ->END
* ["I see, well I can offer her a spot in my car if you would trust that."]
    #speaker: Laura
    "Oh goodness, you have no idea what a savior you are." 
    "Sasha sweetie, this nice person is going to take you to saftey ok?"
    #speaker: Sasha
    "Bu-but mom... I don't want to leave you.." 
    #speaker: Laura
    "I know love, but I will be there to save you soon ok?"
    "Take that space book of your's and read that on your way."
    "Goodbye sweetie, I love you" 
    #speaker: Player 
    You watch as she hugs her daughter tightly. Sasha walks over to you with a backpack full of books, she looks slightly dazed.
    * *  ["Hi Sasha, we are gonna go on a road trip ok!"]
    -
    * ["I see you're a big fan of astronauts, do you have any fun facts?"]
    You know you're not great with kids, but you couldn't imagine leaving her here in these conditions.
    You open the car door for her and you both continue on the drive.
    -> END
    


-> END



=== Illinois ===
Never thought I would actually step foot in Illinois but here we are, there's always a first for everything. #speaker: Player 
Excuse me mister, do you know where I could find the closest gas station?
Hrmph, I've seen plenty of punks like you coming by here causing all sorts of trouble. *cough cough* Be on your way now. #speaker: Peter
Please sir, I'm just looking for some supplies to help on my drive. I've come from Florida and I'm only about half way to the bunker. #speaker: Player
Bunker?!? Don't tell me you beleive in all this alien shit. *cough cough* I've seen plenty of these so called viruses come and go. They haven't gotten me yet so why should I leave? #speaker: Peter
* [Based off the things I've witnessed myself, I wouldn't be too sure of that. This virus is messing people up bad.]  #speaker: Player
    Nothing a little *cough cough* medicine can't fix. #speaker: Peter 
* [Listen I don't blame you, I don't know how much of this I believe either but they're closing down the state lines. Everyone's gotta leave.] #speaker: Player
    Not me, I'm staying right here with the r- *cough*.. excuse me.. the rest of my farm  #speaker: Peter
- I hear ya man, but anyway, do you know of any gas stations around here? #speaker: Player
Not any open within at least an hour , I'll tell ya what though, since I beleive we see eye to eye about most. #speaker: Peter
How about you follow me up the way to my cabin I'll let ya leave with a few things. 
* [Thats awfully generous, but I should really get going. Can't get caught in any more traffic.] #speaker: Player 
    I know that feeling, well feel free to look around the street here. People leave things around all the time. 
    * * [Thank you sir. Are you sure you don't want to hitch a ride to the bunker, I've got more room in the back.] #speaker: Player 
    So the roads really are that bad? I guess it can't be that bad of an idea.*cough cough* I guess I'll hitch a ride, thanks man. #speaker: Peter
        * * * [Continue on the drive.]
        * * * [Search the nearby road for left over supplies. -4 Hours] 
    * * [ Stay Safe out there, I hope the storm doesn't cause too much hard to your farm.] 
        - -> END
*[That would be incredibly helpful. Anything you could offer is great. -4 hours] #speaker: Player #hours: hours -4
    I figured my supplies aren't doing anyone justince just sitting around here doing nothing. # speaker: Peter
    * * [Search for food and gas] #food: true #gas: true 
    * * [Search for gas and water]  #gas: true #water: true 
    * * [Search for  food and water] #food: true #water: true
    As much as a pain you young folk are, I wish you the best of luck out there.#speaker: Peter
    I wouldn't wanna be out on those roads, but more importantly I cant leave my crops out here alone.
- ->END


=== NorthDakota ===
#speaker: Player 
"Wow, this place kinda reminds me of my old campus. What a small world we live in." 
You notice an... odd.. looking man running around the grassy field infront of what appears to be the science building. 

#speaker: Dr. Thompson 
"HEY! YOU THERE! Stay back, and I mean it, don't come ANY closer to me." 
#speaker: Player
This gut is a nut job I can already tell. 
"Woah woah, I don't mean any harm. I just stumbled across this campus on my drive to the bunker." 
#speaker: Dr. Thompson 
"Bunker you say, where.. the government is. Fascinating... very very fascinating..."
#speaker: Player 
* "Hey buddy are you ok?"
    ->ND2
* Why are you acting so... strange?"
    ->ND2
    
== ND2 ===
#speaker: Dr. Thompson 
- "I have a secret to tell you, but you can't tell ANYONE. Not even anyone on that little phone of yours. YOU SWEAR?"
#speaker: Player 
* * "Alright man I swear I swear, whatever you say is safe with me." 
    ->ND3
* * "You're insane, I don't even know you." 
    ->ND3

== ND3 ==
#speaker: Dr. Thompson 
"My name is Dr. Shaun Thompson, Ph. D in biotechnology. And today, November 6th, 1995 marks the date I found the cure for the radioactive sporestorm that is threatening North America. 
#speaker: Player 
* * "I should really get going now..."
    #speaker: Dr. Thompson
    "Not quite yet my friend, there is still much to discuss."
    ->ND4
* * A cure? That sounds a little too good ot be true don't you think?"
    #speaker: Dr. Thompon
    "Do you doubt Dr. Thompson?? That's absurd. My spore neautrilizer is by far the most advanced creation the governmetn could ever witness." 
    ->ND4
    
=== ND4 ==
#speaker: Dr. Thompson
"If only I could make it back to Washington with this news, I could be the greatest hero of the 20th century." 
#speaker: Player
"Washington you say?"
#speaker: Dr. Thompson
"Well yes, that is where head government bunker is correct? I've been working so hard in my office I didn't even think of how I will get there." 
#speaker: Player 
* "Well, I'm on my way there now. Is it something I can take with me?" 
    #speaker: Dr. Thompson
    "OH HEAVENS NO. Tools like these cannot be delivered without a professional like me around. I must accompany you." 
    #speaker: Player
    * * "Well doc, if that's the only way then so be it, hop in."
        -> DOCJOIN
    * * "I think it's probably safest if you stay here, sorry doc."
        #speaker: Dr. Thompson
        "I understand, well, maybe with the leftover parts the physics professors left behind I could create a make shift teleporter. Tally Ho!"
        #speaker: Player
        "Alright well just... be safe and uh... dont't burn anything down!"
        Huh, well anyways. 
        * * * I should probably check that shed over there for some gasoline while I'm here. 
        -> END
        * * * Time to hit the road, I don't want wanna be by this lunatic for any second longer. 
        -> END
        
        
#speaker: Player 
* "If you promise you won't zap me with any of your fancy trinkets, I could let you join me on my drive." 
    ->DOCJOIN
    === DOCJOIN=== 
    #speaker: Dr. Thompson
    "Well isn't this a joyous set of events. I shall join you on your journey to Washington State and we shall save the planet!"
    "Quick! Let's rummage through the old janitor shed for some extra gasoline. It won't take too long" 
    #speaker: Player 
    * * Works for me, I could always benefit from some free gas." -3 Hours #hours: 3
    
    * * "It's probably best if we hit the road now, don't want to be driving too late." 
#speaker: Dr. Thompson
- "Well Tally Ho! Let's be on our way"
#speaker: Player 
What a strange guy, but surely he's trustworthy... right?
->END
        
->END













=== Nebraska === 
#speaker: Player 
"Holy shit this place is like a ghost town."
As you approach the closed corner market, you notice a man sitting on the bench all alone.
You roll your window down as you approach. 

"Excuse me sir, are you ok out there?" 
#speaker: Matt
"God is that you?"    
#speaker: Player
* "No.. over here to your right.. the only car on the road.."
* "Hey dipship, I'm in the car right next to you." 

#speaker: Matt
- "Oh, I apologize. I'm a little loopy from being out here in the cold." 

#speaker: Player 
"It's ok, what are you doing out here anyway?" 

#speaker: Matt
"I was supposed to catch a flight to Idaho to see my family, but of course all the airports shut down so now I'm stuck in who knows where." 

#speaker: Player
* "Ouch thats tough, can't imagine being stuck out here in this weather." 
    #speaker: Matt
    "I bet the heat in your car feels pretty nice right about now. 
    
* "I'm so sorry, when is the last time you saw them?"
    #speaker: Matt
    "It's been 4 months. I was on an international work trip when my layover got cancelled. Hmm, just my luck."
   
#speaker:  
- "Oh wow." 

#speaker: Matt
"Sorry, I don't mean to dump all this on you." 

#speaker: Player 
"It's all good, I can imagine you're stressed."

#speaker: Matt
"Hey man, I hate to ask this but... do you think I could hitch a ride to Idaho. I have no other option man im desperate."

#speaker: Player 
hmm, if I pick this man up I have to drop him off in Idaho. Is it too far out of my way?

* "I don't know if I have any more room in my car man, I'm sorry."
    #speaker: Matt
    "No worries man, I totally get it. I am a stranger after all." 
    "By the way, there's an abandoned grocery store up here on the corner, I would check it out if you're looking for supplies." 
    #speaker: Player 
    "Thanks man. I should be off now but, stay safe out there!"
    You slowly drive away from Matt on the corner. You see him look longingly at your car from the rear view mirror. 
    * * Stop for supplies at the grocery store.
        * * * Food would be best. 
        ->END
        * * * Definitly some water. 
        -> END
    * * Keep driving. 
        "I've still got quite a bit to go, let's hit the road. 
        -> END


* "Of course you can! No man could leave someone stranded out here in this condition." 
    #speaker: Matt
    "Oh man, you have no idea how much of a blessing this is. I don't have much to offer, but I have some food for us to share." #food: true 
    #speaker: Player
    "Anything you have would be of help, thank you." 
    #speaker: Matt
    "By the way, there's an empty grocery store up here on the corner. If we want to stop there I can see what they left behind." 
    #speaker: Player 
        * * "That sounds like a perfect plan." 
            #speaker: Matt 
            "What would you like me to get?" 
            #speaker: Player 
            * * * "Food would be best -2 hours"
                #speaker: Matt
                "Alright, let's hit it." 
                ->END
            * * * "Definitly some water -2 hours"
            #speaker: Matt
            "Alright, let's hit it." 
                    ->END
        * * "I think it's best if we keep driving for now." 
            #speaker: Matt
            "Probably a good idea. Well let's hit the road, we have a long drive ahead of us!"
            #speaker: Player  to themself 
            heh, yeah... "we"...
                    ->END
    
    

-> END




=== SouthDakota === 
#speaker: Player 
I thought nothing could get creepier than the last place, but I stand corrected. 
Oh and would you look at that, just when I thought thing's couldn get scarier, there's an old women on the porch there.
Let me not be too judgemental. 
"Excuse me ma'am, do you know about the evacuation."
#speaker: Carol
"If I hear one more hippie coming in here running their mouth..."
#speaker: Player 
* "That's very rude to say to someone who is just offering to help."
    #speaker: Caraol
    "Help with what? This is God's plan all along, im exactly where he wants me to be."
    #speaker: PLayer
    "I'm sorry, did you say.... Gods plan?"
    -> SD1
    
    
* "I come in peace ma'am, I promise I'm just passing through." 
    #speaker: Carol
    "Only time I'll have any peace is when this rapture comes and takes me there." 
    #speaker: Player 
    "Im sorry, did you say.. rapture?"
    -> SD1
=== SD1 ===
#speaker: Carol
"Well yes precisley" 
"Last sunday Pastor John said that soon there would be a sign from God that proves you are exactly where you need to be."
"And then the following week I hear about this storm spore that's causing a ruckuss. I'll tell you what this is.. it's Gods Rapture!" 
#speaker: Player 
* "Ma'am, I think it may be a good idea to take you somewhere safe, I don't think you're thinking clearly." 
    #speaker: Carol
    "Oh I am thinking very clearly. In fact, this is probably the clearest I've ever thought in my whole life."
* "Ok it's official, I think you're the craziest one I've met so far." 
    #speaker: Carol
    "You're laughing now, but it wont be funny still when those clouds above you part ways and God's hand is reaching out to save his children." 
#speaker: Player 
- "Yeah?"
#speaker: Carol 
"I have spent years practicing my religion and that does not stop when the government tell's me to." 
#speaker: Player 
* "No one's telling you to stop, but maybe it would be a good idea to go to the bunker so you can meet other people with the same ideas." 
    #speaker: Carol
    "Like I said, only god can tell me what to do and you're not him! If god wants me to go to the bunker he would have told me by now."
    #speaker: Player
    * * "Funny you say that, God actually just told me he wanted you to come to the bunker with me."
        #speaker: Carol
        "Wait.. god told you that?"
        #speaker: Player
        "Yeah, it's true! I'm on my way to the bunker now if you'd like to join me there."
        #speaker: Carol
        "Well if that's what god wants, that's what is best for me. I shall join you on the rest of the journey."
        #speaker: PLayer
        I know this was the right choice, but oh am I in for a long ride....
        ->END
    * * "Alright well... if that's what god want's then that's what's gonna happen."
        "I wish you a good life here at this doorstep, don't drive yourself too mad." 
        #speaker: Carol
        "MAD? I'll show you mad" 
        #speaker: player 
        You rush back to your car before she can catch up. You drive off knowing that she probably won't be the craziest one you'll meet on this journey..." 
        ->END
    
* "I think you might be a lost cause." 
#speaker: Carol
"LOST CAUSE? I'll show you a lost cause."
#speaker: player 
You rush back to your car before she can catch up. You drive off knowing that she probably won't be the craziest one you'll meet on this journey..." 

->END








=== WyomingWithSasha == 
#speaker: Player
"Wow... I've never been to Yellow Stone before. It's quite beautiful actually."
"Who knew a deadly storm is what would have brought me here..."
    #speaker: Ezekial 
    "Hey! You There! Don't come any closer to me with that radio of yours!"
    "The frequencies are gonna tell them exactly where I am!"
    #speaker: player
    "Frequencies? From a damn radio..."
    #speaker: Ezekial
    "Well you see, the government has been playing around with this new thing called 5G, they say it's supposed to be the biggest and brightest new thing, but I don't belive it for just one minute." 
    #speaker: Player
    * "You sure talk a lot don't you mister."
    * "I can't believe I ran into another crazy."
        #speaker: Ezekial
        "People always say I'm crazy, but I think crazy is exciting. You should've seen the fun my daughter and I had before her mom called me crazy." 
        #speaker: Player 
        * * "Oh man, I'm so sorry. That must be very difficult." 
                    
            
                
        * * "I can see why she said that." 
            #speaker: Ezekial
            - "Oh Sasha, if only I could see her one more time before this storm takes us all." 
            #speaker: Player
            "Wait did you say Sasha? That's such a coincidence."
            "I'm taking care of this young girl right now her name is Sasha."
            You point to the girl in your backseat, here eyes are just barely visible out the window when you see her face light up.
            #speaker: Ezekial
            "This can't be real! How did you manage to find my daughter! She lives with her mother in Mississippi."
            #speaker: Player 
            * "How can you be sure that's your daughter?"
                -> W1
            * "Mississipi you say? That's exactly where her mother left her with me." 
                -> W1
            === W1 ===
            #speaker: Ezekial 
            "I know those eyes from anywhere, she looks just like her mother." 
            #speaker: Player 
            you watch as Sasha rushes from the car and jumps into her fathers arms.
            #speaker: Ezekial
            "Oh sasha dear how I've missed you, all these adventures I've had to go on without you!"
            #speaker: Player 
            * "If this is true, you must come with us to the bunker with your daughter."
                #speaker: Ezekial
                "Oh this is the happiest day of my life! I'm reunited with my sweet girl and saved by this random person with their toxic radio box." 
                #speaker: Player
                "Ok well, you have to get in my so-called toxic radio box if we are going to make it to saftey." 
                You watch as Ezekial picks up Sasha and rushes her to the backseat. 
                Guess I have another passenger...
                ->END
            * "I'm sorry to break up this special moment, but I was given special instructions by her mother to take her to saftey, I can't let her down now." 
                #speaker: Ezekial
                "I understand, I only want what's best for her. I know that's where she'll be the safest." 
                "Not for me though! I must stay here where the signals can't reach me!" 
                "Goodbye Sasha and random person I just met!"
                #speaker: Player
                You watch as Ezekial hugs his daughter tightly before rushing back to his tent. 
                What a strange world we live in, you think to yourself as you walk Sasha back to the car.
                -> END
            
    
    -> END

=== WyomingWithoutSasha === 
#speaker: Player
"Wow... I've never been to Yellow Stone before. It's quite beautiful actually."
"Who knew a deadly storm is what would have brought me here..."
    #speaker: Player
    "I can't imagine anyone being at a state park during a government shutdown." 
    * "A little walk through the park never hurt anyone, might be good to get some fresh air."
        You take a walk through the park
        As you lose track of time... you notice the storm approaching at a steady speed. 
        You turn around... which path did you take... left... or right...
        ->Death
    * "It's probably best to not stop for long."
        "Maybe I can pick up some food from that vending machine over there." 
        -> END
 

-> END














=== Death ===
You freeze in place, realizing suddenly that the spores in the air are multiplying at a frightening rate. You've stayed here too long.

--> END





