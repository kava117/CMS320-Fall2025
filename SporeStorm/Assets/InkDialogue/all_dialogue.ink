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




=== OutOfTime ===
You freeze in place, realizing suddenly that the spores in the air are multiplying at a frightening rate. You've stayed here too long.

--> END





