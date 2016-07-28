USE epicodex
-- public List<Comments> GetCommentsForMessage(int messageId)
SELECT * FROM comments WHERE comments.message_Id = 1

-- public List<Message> GetHobbyMessages(Profile p)
SELECT messages_posts.* FROM
profiles JOIN profile_subhobby ON (profiles.id = profile_subhobby.profile_id)
	JOIN messages_subhobbies ON (profile_subhobby.subhobby_id = messages_subhobbies.subhobby_id)
	JOIN messages_posts ON (messages_subhobbies.message_id = messages_posts.id)
WHERE profiles.id = 1

-- get profile 1
SELECT * FROM profiles
WHERE id = 1

SELECT * FROM profile_subhobby

SELECT * FROM messages_subhobbies

-- public List<Message> GetNonHobbyMessages()
SELECT * FROM messages_posts
WHERE type_id != 4

SELECT * FROM messages_posts




