@interface UGTAlternative : NSObject

@property (nonatomic, strong, readonly) NSString *name;
@property (nonatomic, strong) NSMutableDictionary *attributes;

- (UGTAlternative *)initWithName:(NSString *)name;

- (UGTAlternative *)initWithName:(NSString *)name andAttributes:(NSDictionary *)attributes;

- (NSDictionary *)getJSON;

- (void)addAttribute:(id)value forKey:(NSString *)key;

@end
